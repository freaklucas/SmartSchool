namespace SmartSchool.Models
{
  public class StudentDiscipline
  {
    public StudentDiscipline() { }
    public StudentDiscipline(int studentId, int disciplineId)
    {
      this.StudentId = studentId;
      this.DisciplineId = disciplineId;
    }
    public int StudentId { get; set; }
    public int DisciplineId { get; set; }

    public DateTime DateInit { get; set; } = DateTime.Now;
    public DateTime? DateEnd { get; set; }
    public int? ValueNote { get; set; } = null;
    public Student Student { get; set; }
    public Discipline Discipline { get; set; }
  }
}