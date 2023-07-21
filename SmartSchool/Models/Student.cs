namespace SmartSchool.Models {
  public class Student {
    
    public Student() {}
    public Student(int id, string name, strint lastName, string numberPhone) {
      this.Id = id;
      this.Name = name;
      this.LastName = lastName;
      this.NumberPhone = numberPhone;
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public string LastName {get; set;}
    public string NumberPhone { get; set; }

  }
}