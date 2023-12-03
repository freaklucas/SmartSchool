namespace SmartSchool.Models
{
  public class Student
  {
    public Student() { }
    public Student(
        int id,
        int registration,
        string name,
        string lastName,
        string numberPhone,
        DateTime birthDate
      )
    {
      this.Id = id;
      this.Name = name;
      this.LastName = lastName;
      this.NumberPhone = numberPhone;
      this.Registration = registration;
      this.BirthDate = birthDate;
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public string LastName { get; set; }
    public string? NumberPhone { get; set; }
    public int Registration { get; set; }
    public DateTime BirthDate { get; set; }
    public DateTime InitDate { get; set; } = DateTime.Now;
    public DateTime? EndDate { get; set; } = null;
    public bool Ativo { get; set; } = true;

    public IEnumerable<StudentDiscipline>? StudentsDisciplines { get; set; }

    public static implicit operator List<object>(Student v)
    {
      throw new NotImplementedException();
    }
  }
}