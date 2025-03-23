namespace TaskManagementSystem.Data;
public class TaskAllocation
{
    public int Id { get; set; }

    public TaskType? TaskType { get; set; }
    public int TaskTypeId { get; set; }

    public ApplicationUser? Employee { get; set; }
    public string EmployeeId { get; set; }

    public WorkingDay? WorkingDay { get; set; }
    public int WorkingDayId { get; set; }



}
