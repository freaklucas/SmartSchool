namespace SmartSchool.Models
{
  public class Teacher
  {
    public Teacher() { }
    public Teacher(int id, int registration, string name, string lastName)
    {
      this.Id = id;
      this.Registration = registration;
      this.Name = name;
      this.LastName = lastName;
    }
    public int Id { get; set; }
    public string Name { get; set; }
    public string LastName { get; set; }
    public string NumberPhone { get; set; }
    public int Registration { get; set; }
    public DateTime InitDate { get; set; } = DateTime.Now;
    public DateTime? EndDate { get; set; } = null;
    public bool Ativo { get; set; } = true;
    public IEnumerable<Discipline> Disciplines { get; set; }
  }
}