namespace TaskManagementSystem.Common.Exceptions
{
	public class InvalidTimeInputException : Exception
	{

		public InvalidTimeInputException()
		{
		}
		public InvalidTimeInputException(string message)
			: base(message)
		{
		}
		public InvalidTimeInputException(string message, Exception inner)
			: base(message, inner)
		{
		}
	}
}
