namespace TaskManagementSystem.Common.Exceptions;

public class SameDateExistsException :Exception
{
	public SameDateExistsException()
	{
	}
	public SameDateExistsException(string message)
		: base(message)
	{
	}
	public SameDateExistsException(string message, Exception inner)
		: base(message, inner)
	{
	}
}

