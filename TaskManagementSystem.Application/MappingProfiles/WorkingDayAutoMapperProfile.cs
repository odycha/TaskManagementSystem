using AutoMapper;

namespace TaskManagementSystem.Application.MappingProfiles;

public class WorkingDayAutoMapperProfile : Profile
{
    public WorkingDayAutoMapperProfile()
    {
        CreateMap<WorkingDay, WorkingDayReadOnlyVM>();
        CreateMap<WorkingDayCreateVM, WorkingDay>();
		CreateMap<WorkingDayCreateVM, WorkingDay>().ReverseMap();
	}
}






