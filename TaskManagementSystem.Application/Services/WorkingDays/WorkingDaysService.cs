using AutoMapper;
using Microsoft.EntityFrameworkCore;


namespace TaskManagementSystem.Application.Services.WorkingDays;

public class WorkingDaysService(ApplicationDbContext _context, IMapper _mapper) : IWorkingDaysService
{
    public async Task<List<WorkingDayReadOnlyVM>> GetAll()
    {
        var data = await _context.WorkingDays.ToListAsync();
        var viewData = _mapper.Map<List<WorkingDayReadOnlyVM>>(data);
        return viewData;
    }

    public async Task Create(WorkingDayCreateVM model)
    {
        //Cant create 2 working days at the same date
        var sameDateWorkingDay = await _context.WorkingDays
            .Where(w => w.Day == model.Day)
            .AnyAsync();
        if(sameDateWorkingDay == true)
        {
            throw new SameDateExistsException("Same date exists");
        }
        //checking if startTime is before endTime
        if (model.StartTime >= model.EndTime)
        {
            throw new InvalidTimeInputException("Start time must be before end time");
		}
        var WorkingDay = _mapper.Map<WorkingDay>(model);
        _context.Add(WorkingDay);
        await _context.SaveChangesAsync();
    }

    public async Task<T?> Get<T>(int id) where T : class
    {
        var data = await _context.WorkingDays.FirstOrDefaultAsync(x => x.Id == id);
        if (data == null)
        {
            return null;
        }
        var viewData = _mapper.Map<T>(data);
        return viewData;
    }

    public async Task Edit(WorkingDayCreateVM model)
    {
        var sameDateWorkingDay = await _context.WorkingDays
            .Where(w => (w.Day == model.Day) && (w.Id != model.Id))
            .AnyAsync();
        if(sameDateWorkingDay == true)
        {
            throw new SameDateExistsException("same date exists");
        }
        if(model.StartTime >= model.EndTime)
        {
            throw new InvalidTimeInputException("End Time must be later than start time");
        }
        var data = _mapper.Map<WorkingDay>(model);
        _context.Update(data);
        await _context.SaveChangesAsync();
    }


    public async Task Remove(int id)
    {
        var data = await _context.WorkingDays.FirstOrDefaultAsync(x => x.Id == id);
        if (data != null)
        {
            _context.Remove(data);
            await _context.SaveChangesAsync();
        }
    }

}







