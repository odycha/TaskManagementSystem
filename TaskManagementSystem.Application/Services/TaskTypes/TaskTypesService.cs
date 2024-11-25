using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TaskManagementSystem.Application.Services.TaskTypes;

public class TaskTypesService(
    ApplicationDbContext _context, 
    IMapper _mapper, 
    IUserService _userService, 
    IEmailSender _emailSender) : ITaskTypesService
{
    public async Task<List<TaskTypeReadOnlyVM>> GetAll(DateOnly? fromDate, DateOnly? toDate, TimeOnly? fromTime, TimeOnly? toTime, string? department, int? minimumSkillLevel, bool? isAllocatted)
    {
        //get the data from the database
        var taskTypes = await _context.TaskTypes
            .OrderBy(t => t.StartDate)
            .OrderBy(t => t.StartTime)
            .ToListAsync();
        //TODO: PUT FILTER LOGIC IN METHOD?
        if (taskTypes == null)
        {
            return null;
        }
        //Date filtering
        if (fromDate.HasValue && toDate.HasValue)
        {
            taskTypes = taskTypes
                .Where(t => (t.StartDate >= fromDate && t.StartDate <= toDate))
                .ToList();
        }
        if (fromDate.HasValue && !toDate.HasValue)
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
        //Time filtering
        if (fromTime.HasValue && toTime.HasValue)
        {
            taskTypes = taskTypes
                .Where(t => (t.StartTime >= fromTime && t.EndTime <= toTime))
                .ToList();
        }
        if (fromTime.HasValue && !toTime.HasValue)
        {
            taskTypes = taskTypes
                .Where(t => t.StartTime >= fromTime)
                .ToList();
        }
        if (!fromTime.HasValue && toTime.HasValue)
        {
            taskTypes = taskTypes
                .Where(t => t.EndTime <= toTime)
                .ToList();
        }

        //Rest filtering
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
        if (model.StartTime >= model.EndTime)
        {
            throw new InvalidTimeInputException("End time must be later than start time");
        }
        var taskType = _mapper.Map<TaskType>(model);
        _context.Add(taskType);  //The Add method registers the taskType entity with the DbContext so it can be tracked and added to the database.
        await _context.SaveChangesAsync();
    }


    //GET -- Generic method so that it can be implemented by more actions
    //returns a specific record
    public async Task<T?> Get<T>(int id) where T : class
    {
        var data = await _context.TaskTypes
            .Include(x => x.TaskAllocation)
            .FirstOrDefaultAsync(x => x.Id == id);
        if (data == null)
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
                StartTime = data.StartTime,
                EndTime = data.EndTime,
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
        var data = await _context.TaskTypes
            .Include(t => t.TaskAllocation.Employee)
            .FirstOrDefaultAsync(x => x.Id == id);
        if (data != null)
        {
            //if task was allocated inform employee about the removal
            if (data.Allocated == true)
            {
                await _emailSender.SendEmailAsync(data.TaskAllocation.Employee.Email, "Task Deleted", $"The task: {data.Name} that you were assigned has been deleted!");
            }
            _context.Remove(data);
            await _context.SaveChangesAsync();
        }
    }

    public async Task Edit(TaskTypeEditVM model)
    {
        if (model.StartTime >= model.EndTime)
        {
            throw new InvalidTimeInputException("End time must be later than start time");
        }
        //converting to data model
        var taskType = _mapper.Map<TaskType>(model);
        //if task was allocated - we are deleting the allocation
        //if (taskType.Allocated == true) - i cant type that because when the form is submitted the allocated is defaulted to false
        var allocation = await _context.TaskAllocations
            .Where(a => a.TaskTypeId == taskType.Id)
            .Include(a => a.Employee)
            .SingleOrDefaultAsync();
        if (allocation != null)
        {
            //if task was allocated inform employee about the task edit and allocation deletion
            {
                await _emailSender.SendEmailAsync(allocation.Employee.Email, "Task Edited", $"The task: {taskType.Name} that you were assigned has been edited and you were unassigned!");
            }
            _context.Remove(allocation);
            await _context.SaveChangesAsync();
        }

        _context.Update(taskType);
        await _context.SaveChangesAsync();
    }

}