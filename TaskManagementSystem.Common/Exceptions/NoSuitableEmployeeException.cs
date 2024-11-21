namespace TaskManagementSystem.Common.Exceptions
{
	public class NoSuitableEmployeeException :Exception
	{
        //public string UnallocatedTaskName { get; set; }
        public NoSuitableEmployeeException()
		{
		}

		public NoSuitableEmployeeException(string message)
			: base(message)
		{
		}
		//public NoSuitableEmployeeException(string taskName)
		//: base($"Working day not found for {taskName}")
		//{
		//	UnallocatedTaskName = taskName;
		//}
		public NoSuitableEmployeeException(string message, Exception inner)
			: base(message, inner)
		{
		}
	}
}
