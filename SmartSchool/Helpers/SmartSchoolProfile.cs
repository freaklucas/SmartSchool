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
            //.ForMember(
            //    des => des.NumberPhone,
            //    opt => opt.MapFrom(src => $"{src.NumberPhone} {src.NumberPhone}")
            //)
            //.ForMember(
            //    des => des.Registration,
            //    opt => opt.MapFrom(src => $"{src.Registration} {src.Registration}")
            //)
            //.ForMember(
            //    des => des.InitDate,
            //    opt => opt.MapFrom(src => $"{src.InitDate} {src.InitDate}")
            //)
            .ForMember(
                dest => dest.BirthDate,
                opt => opt.MapFrom(src => src.BirthDate.GetCurrentAge())
                );

        CreateMap<StudentDTO, Student>();
    }
}