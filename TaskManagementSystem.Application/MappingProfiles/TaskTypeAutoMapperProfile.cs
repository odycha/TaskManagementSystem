using AutoMapper;
using TaskManagementSystem.Application.Models.TaskTypes;

namespace LeaveManagementSystem.Application.MappingProfiles
{
    public class TaskTypeAutoMapperProfile : Profile
    {
        public TaskTypeAutoMapperProfile()
        {
            CreateMap<TaskType, TaskTypeReadOnlyVM>();
			CreateMap<TaskTypeCreateVM, TaskType> ();
            CreateMap<TaskType, TaskTypeEditVM>();
            CreateMap<TaskType, TaskTypeEditVM>().ReverseMap();
        }
    }
}







//It is common practise to have multiple automapper profiles(in program.cs we stated
//get all the automapper profiles from the whole assembly)
//we renamed the automapper to leavetypeautomapper and created a seperate 
//automapper profile for the leaveallocation
