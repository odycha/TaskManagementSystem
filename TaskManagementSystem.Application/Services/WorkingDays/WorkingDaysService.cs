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
        var sameDateWorkingDay = await _context.WorkingDays
            .Where(w => w.Day == model.Day)
            .AnyAsync();
        if(sameDateWorkingDay == true)
        {
            //TODO: MAKE A NEW EXCEPTION CLASS?
            throw new InvalidOperationException("Same date exists");
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







