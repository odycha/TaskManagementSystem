namespace TaskManagementSystem.Data;
public class TaskAllocation
{
    public int Id { get; set; }

    //1 task type can have many allocations eg.3 employees 
    //according to the department they work in, their skill level and availability
    public TaskType? TaskType { get; set; }
    public int TaskTypeId { get; set; }

    public ApplicationUser? Employee { get; set; }
    public string EmployeeId { get; set; }

    public WorkingDay? WorkingDay { get; set; }
    public int WorkingDayId { get; set; }



}
