using AutoMapper;
using SmartSchool.DTO;
using SmartSchool.Models;

namespace SmartSchool.Helpers;

public class SmartSchoolProfile : Profile
{
    public SmartSchoolProfile()
    {
        CreateMap<Student, StudentDTO>()
            .ForMember(
                des => des.Name,
                opt => opt.MapFrom(src => $"{src.Name} {src.LastName}")
            )
            .ForMember(
                dest => dest.BirthDate,
                opt => opt.MapFrom(src => src.BirthDate.GetCurrentAge())
                );
    }
}