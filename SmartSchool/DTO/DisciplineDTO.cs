using SmartSchool.Models;

namespace SmartSchool.DTO;
public class DisciplineDTO
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int CargaHoraria { get; set; }
    public int TeacherId { get; set; }
    public int? PreRequisitId { get; set; } = null;
    public Discipline PreRequisit { get; set; }
    public Teacher Teacher { get; set; }
    public int CourseId { get; set; }
    public Course Course { get; set; }

    public IEnumerable<StudentDiscipline> StudentsDisciplines { get; set; }
}