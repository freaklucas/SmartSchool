namespace SmartSchool.DTO;
public class StudentRegisterDTO
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string LastName { get; set; }
    public string? NumberPhone { get; set; }
    public int Registration { get; set; }
    public DateTime BirthDate { get; set; }
    public DateTime InitDate { get; set; } = DateTime.Now;
    public DateTime? EndDate { get; set; } = null;
    public bool Ativo { get; set; } = true;
}

