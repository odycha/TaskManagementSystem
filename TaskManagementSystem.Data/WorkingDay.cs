namespace TaskManagementSystem.Data;

public class WorkingDay
{
    public int Id{ get; set; }
    public DateOnly Day { get; set; }
    public TimeOnly StartTime { get; set; }
    public TimeOnly EndTime { get; set; }
    public string Comments { get; set; }
}
