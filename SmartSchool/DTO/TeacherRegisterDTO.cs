using SmartSchool.Models;

namespace SmartSchool.DTO;
public class TeacherRegisterDTO
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string? NumberPhone { get; set; }
    public int Registration { get; set; }
    public bool Ativo { get; set; } = true;

    public IEnumerable<Discipline>? Disciplines { get; set; }
}
