using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartSchool.Data;
using SmartSchool.Models;

namespace SmartSchool.Controllers {
  [ApiController]
  [Route("api/[controller]")]
  public class StudentController : ControllerBase {
    private readonly SmartContext _context;
    public  readonly IRepository _repo;
    public StudentController(SmartContext context, IRepository repo) {
      _context = context;
      _repo = repo;
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
      _repo.Add(student);
      if(_repo.SaveChanges()) 
        return  Ok(student);

      return BadRequest("Aluno não foi cadastrado!");
    }

    [HttpPut("{id}")]
    public IActionResult PutStudent(int id, Student student){
      var studentExists = _context.Students.
        AsNoTracking().
        FirstOrDefault(s => s.Id == id);
      
      _repo.Update(student);
      if(_repo.SaveChanges()) 
        return  Ok(student);

      return BadRequest("Aluno não foi cadastrado!");
    }
    
    [HttpPatch("{id}")]
    public IActionResult PatchStudent(int id, Student student){
      var studentExists = _context.Students
        .AsNoTracking()
        .FirstOrDefault(s => s.Id == id);
      
      _repo.Patch(student);
      if(_repo.SaveChanges()) 
        return  Ok(student);

      return BadRequest("Aluno não foi cadastrado!");
    }

    
    [HttpDelete("{id}")]
    public IActionResult DeleteStudent(int id){
      var student = _context.Students.FirstOrDefault(s => s.Id == id);
      if(student == null) return BadRequest("Aluno não existe!");

      _repo.Delete(student);
      if(_repo.SaveChanges()) 
        return  Ok(student);

      return BadRequest("Aluno não foi cadastrado!");
    }
  }
}