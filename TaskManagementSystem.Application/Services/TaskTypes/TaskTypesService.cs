﻿using TaskManagementSystem.Data;
using TaskManagementSystem.Application.Models.TaskTypes;
using Microsoft.EntityFrameworkCore;
using AutoMapper;

namespace TaskManagementSystem.Application.Services.TaskTypes;

public class TaskTypesService(ApplicationDbContext _context, IMapper _mapper, IUserService _userService) : ITaskTypesService
{
	public async Task<List<TaskTypeReadOnlyVM>> GetAll(DateOnly? fromDate, DateOnly? toDate, string? department, int? minimumSkillLevel, bool? isAllocatted)
	{
		//get the data from the database
		var taskTypes = await _context.TaskTypes.ToListAsync();
		//TODO: PUT FILTER LOGIC IN METHOD?
		if (taskTypes == null)
		{
			return null;
		}
		if (fromDate.HasValue && toDate.HasValue)
		{
			taskTypes = taskTypes
				.Where(t => (t.StartDate >= fromDate && t.StartDate<= toDate))
				.ToList();
		}
		if( fromDate.HasValue && !toDate.HasValue) 
		{
			taskTypes = taskTypes
				.Where(t => t.StartDate >= fromDate)
				.ToList();
		}
        if (!fromDate.HasValue && toDate.HasValue)
        {
            taskTypes = taskTypes
                .Where(t => t.StartDate <= toDate)
                .ToList();
        }
        if (!string.IsNullOrEmpty(department))
		{
			taskTypes = taskTypes
				.Where(t => t.Department == department)
				.ToList();
		}
		if (minimumSkillLevel.HasValue)
		{
			taskTypes = taskTypes
				.Where(t => t.SkillLevel >= minimumSkillLevel)
				.ToList();
		}
		if (isAllocatted.HasValue)
		{
			taskTypes = taskTypes
				.Where(t => t.Allocated == isAllocatted)
				.ToList();
		}
		//created the mapping profile for the conversion to TaskTypeReadOnlyVM
		var viewData = _mapper.Map<List<TaskTypeReadOnlyVM>>(taskTypes);
		return viewData;
	}

	public async Task Create(TaskTypeCreateVM model)
	{
		var taskType = _mapper.Map<TaskType>(model);
		_context.Add(taskType);  //The Add method registers the taskType entity with the DbContext so it can be tracked and added to the database.
		await _context.SaveChangesAsync(); 
	}


        //GET -- Generic method so that it can be implemented by more actions
        //returns a specific record
    public async Task <T?> Get<T>(int id) where T : class
	{
		var data = await _context.TaskTypes
			.Include(x => x.TaskAllocation)
			.FirstOrDefaultAsync(x => x.Id == id);
		if(data == null)
		{
			return null;
		}
		var viewData = _mapper.Map<T>(data);
		return viewData;
	}


	public async Task<TaskTypeReadOnlyVM> Get(int id) 
	{
		var data = await _context.TaskTypes
			.Include(x => x.TaskAllocation)
			.FirstOrDefaultAsync(x => x.Id == id);
		if (data == null)
		{
			return null;
		}
		if (data.Allocated == true)
		{
			var employee = await _userService.GetUserById(data.TaskAllocation.EmployeeId);
			var viewData = new TaskTypeReadOnlyVM
			{
				Id = data.Id,
				Name = data.Name,
				StartDate = data.StartDate,
				Department = data.Department,
				Description = data.Description,
				SkillLevel = data.SkillLevel,
				Allocated = data.Allocated,
				employeeListVm = new EmployeeListVM
				{
					FirstName = employee.FirstName,
					LastName = employee.LastName,
					DepartmentName = employee.DepartmentName,
					SkillLevel = employee.SkillLevel,
					Email = employee.Email
				}
			};
			return viewData;
		}
		else
		{
			var viewData = _mapper.Map<TaskTypeReadOnlyVM>(data);
			return viewData;
		}
	}


	public async Task Remove(int id)
	{
		var data = await _context.TaskTypes.FirstOrDefaultAsync(x => x.Id == id);
		if(data != null)
		{
			_context.Remove(data);
			await _context.SaveChangesAsync();
		}
	}

	public async Task Edit(TaskTypeEditVM model)
	{
		//converting to data model
		var taskType = _mapper.Map<TaskType>(model);
        //if task was allocated - we are deleting the allocation
        //if (taskType.Allocated == true) - i cant type that because when the form is submitted the allocated is defaulted to false
		var allocation = await _context.TaskAllocations
			.Where(a => a.TaskTypeId == taskType.Id)
			.SingleOrDefaultAsync();
		if(allocation != null)
		{
			_context.Remove(allocation);
			await _context.SaveChangesAsync();
        }
	
		_context.Update(taskType);
		await _context.SaveChangesAsync();
	}

}