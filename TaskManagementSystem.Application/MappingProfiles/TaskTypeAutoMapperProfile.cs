using AutoMapper;
using TaskManagementSystem.Application.Models.TaskTypes;

namespace LeaveManagementSystem.Application.MappingProfiles
{
    public class TaskTypeAutoMapperProfile : Profile
    {
        public TaskTypeAutoMapperProfile()
        {
            
			CreateMap<TaskTypeCreateVM, TaskType> ();
            CreateMap<TaskType, TaskTypeEditVM>();
            CreateMap<TaskType, TaskTypeEditVM>().ReverseMap();
        }
    }
}

