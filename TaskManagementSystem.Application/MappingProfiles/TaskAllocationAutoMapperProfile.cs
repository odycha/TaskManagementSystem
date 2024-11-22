using AutoMapper;
using System.Collections.Generic;

namespace TaskManagementSystem.Application.MappingProfiles
{
	public class TaskAllocationAutoMapperProfile : Profile
	{
		public TaskAllocationAutoMapperProfile()
		{
			CreateMap<TaskType, TaskTypeReadOnlyVM>();
			CreateMap<TaskType, TaskTypeReadOnlyVM>().ReverseMap();
			CreateMap<ApplicationUser, EmployeeListVM>();
			CreateMap<TaskAllocation, EmployeeAllocationVM>();
			CreateMap<TaskAllocation, TaskAllocationVM>();
		}
	}
}
