using AutoMapper;
using TaskManagementSystem.Application.Models.TaskAllocation;

namespace LeaveManagementSystem.Application.MappingProfiles
{
    public class TaskAllocationAutoMapperProfile : Profile
    {
        public TaskAllocationAutoMapperProfile()
        {
            CreateMap<TaskType, UnallocatedTaskVM>();
            CreateMap<TaskType, UnallocatedTaskVM>().ReverseMap();
        }
    }
}


