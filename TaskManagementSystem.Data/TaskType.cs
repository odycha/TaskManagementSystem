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

    public bool Allocated { get; set; }

    public bool Completed { get; set; }

    // One-to-One relationship
    //edited the TaskTypes so we can access the related TaskAllocation
    public TaskAllocation? TaskAllocation { get; set; }


}
