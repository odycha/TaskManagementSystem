namespace TaskManagementSystem.Common.Exceptions;

public class WorkingDayNotFoundException : Exception
{
	public DateOnly MissingDate { get; }
	public WorkingDayNotFoundException()
    {
    }

    public WorkingDayNotFoundException(string message)
        : base(message)
    {
    }
	public WorkingDayNotFoundException(DateOnly missingDate)
		: base($"Working day not found for {missingDate}")
	{
		MissingDate = missingDate;
	}
	public WorkingDayNotFoundException(string message, Exception inner)
        : base(message, inner)
    {
    }
}
