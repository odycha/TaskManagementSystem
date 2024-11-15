
using System.ComponentModel.DataAnnotations;

namespace TaskManagementSystem.Data;

public class TaskType
{
    public int Id { get; set; }
    [MaxLength(30)]
    public string Name { get; set; }
    public DateOnly StartDate { get; set; }
    public DateOnly EndDate { get; set; }
    [MaxLength(30)]
    public string Department { get; set; }
    [MaxLength(200)]
    public string Description { get; set; }
    
}
