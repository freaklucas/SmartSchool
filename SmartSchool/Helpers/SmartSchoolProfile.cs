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
                des => des.FullName,
                opt => opt.MapFrom(src => $"{src.Name} {src.LastName}")
            );

        CreateMap<StudentDTO, Student>();
        CreateMap<Student, StudentRegisterDTO>().ReverseMap();

        CreateMap<Teacher, TeacherDTO>()
            .ForMember(
                des => des.Name,
                opt => opt.MapFrom(src => $"{src.Name} {src.LastName}")
            )
            .ReverseMap();

        CreateMap<TeacherRegisterDTO, Teacher>().ReverseMap();

        CreateMap<DisciplineDTO, Discipline>().ReverseMap();
    }
}