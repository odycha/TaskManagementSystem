
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskManagementSystem.Data;

public class TaskType
{
    public int Id { get; set; }
    [MaxLength(30)]
    public string Name { get; set; }
    public DateOnly StartDate { get; set; }
    public TimeOnly StartTime { get; set; }
    public TimeOnly EndTime { get; set; }

    [MaxLength(30)]
    public string Department { get; set; }
    public int SkillLevel { get; set; }

    [MaxLength(200)]
    public string Description { get; set; }

    //TODO: Allocated
    public bool Allocated { get; set; }

    // One-to-One relationship
    //we edited the LeaveTypes so we can access the related TaskAllocation
    //? there might not be any related ones
    public TaskAllocation? TaskAllocation { get; set; }


}
