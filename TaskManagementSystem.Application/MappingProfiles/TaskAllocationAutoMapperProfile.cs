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
			CreateMap<ApplicationUser, EmployeeEmailVM>();
			CreateMap<TaskAllocation, EmployeeAllocationVM>();
			CreateMap<TaskAllocation, TaskAllocationVM>();

	
			CreateMap<ApplicationUser, EmployeeAllocationVM>();
		}
	}
}
