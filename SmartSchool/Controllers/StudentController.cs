using Microsoft.AspNetCore.Mvc;
using SmartSchool.Models;

namespace SmartSchool.Controllers {
  [ApiController]
  [Route("api/[controller]")]
  public class StudentController : ControllerBase {
    public List<Student> Students = new List<Student>() {
      new Student() {
        Id= 1,
        Name= "Lucas",
        LastName = "Oliveira",
        NumberPhone = "12766767"
      },
      new Student() {
        Id= 2,
        Name= "Joaozinho",
        LastName = "Joquinha",
        NumberPhone = "99876333"
      },
    };
    public StudentController() {}
    [HttpGet]
    public IActionResult Get(){
      return Ok(Students);
    }

    [HttpGet("byId/{id}")]
    public IActionResult GetById(int id){
      var student = Students.FirstOrDefault(a => a.Id == id);
      if(student == null) return BadRequest("Aluno não encontrado!"); 
      
      return Ok(student);
    }
    [HttpGet("byName")]
    public IActionResult GetByName(string name, string lastName){
      var student = Students.FirstOrDefault(
        a => a.Name.Contains(name) && a.LastName.Contains(lastName));
        
      if(student == null) return BadRequest("Aluno não encontrado!"); 
      
      return Ok(student);
    }
  }
}