using Microsoft.AspNetCore.Mvc;
using SmartSchool.Data;
using SmartSchool.Models;

namespace SmartSchool.Controllers {
  [ApiController]
  [Route("api/[controller]")]
  public class StudentController : ControllerBase {
    private readonly SmartContext _context;
    public StudentController(SmartContext context) {
      _context = context;
    }

    [HttpGet]
    public IActionResult Get(){
      return Ok(_context.Students);
    }

    [HttpGet("byId/{id}")]
    public IActionResult GetById(int id){
      var student = _context.Students.FirstOrDefault(a => a.Id == id);
      if(student == null) return BadRequest("Aluno não encontrado!"); 
      
      return Ok(student);
    }

    [HttpGet("byName")]
    public IActionResult GetByName(string name, string lastName){
      var student = _context.Students.FirstOrDefault(
        a => a.Name.Contains(name) && a.LastName.Contains(lastName));

      if(student == null) return BadRequest("Aluno não encontrado!"); 
      
      return Ok(student);
    }

    [HttpPost]
    public IActionResult PostStudent(Student student){
      return Ok(student);
    }

    
    [HttpPatch("{id}")]
    public IActionResult PatchStudent(int id, Student student){
      return Ok(student);
    }

    [HttpPut("{id}")]
    public IActionResult PutStudent(int id, Student student){
      return Ok(student);
    }
    
    [HttpDelete("{id}")]
    public IActionResult DeleteStudent(int id){
      return Ok(id);
    }
  }
}