﻿using TaskManagementSystem.Data;
using TaskManagementSystem.Application.Models.TaskTypes;
using Microsoft.EntityFrameworkCore;
using AutoMapper;

namespace TaskManagementSystem.Application.Services.TaskTypes;

public class TaskTypesService(ApplicationDbContext _context, IMapper _mapper) : ITaskTypesService
{
	public async Task<List<TaskTypeReadOnlyVM>> GetAll()
	{
		//get the data from the database
		var data = await _context.TaskTypes.ToListAsync();
		//created the mapping profile for the conversion to TaskTypeReadOnlyVM
		var viewData = _mapper.Map<List<TaskTypeReadOnlyVM>>(data);
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
		var data = await _context.TaskTypes.FirstOrDefaultAsync(x => x.Id == id);
		if(data == null)
		{
			return null;
		}
		var viewData = _mapper.Map<T>(data);
		return viewData;
	}

	//TODO: Remove
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
		_context.Update(taskType);
		await _context.SaveChangesAsync();
	}

}