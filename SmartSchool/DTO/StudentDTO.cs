namespace SmartSchool.DTO;

public class StudentDTO
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string LastName { get; set; }
    public string? NumberPhone { get; set; }
    public int Registration { get; set; }
    public DateTime BirthDate { get; set; }
    public DateTime InitDate { get; set; }
    
    public bool Ativo { get; set; }

}