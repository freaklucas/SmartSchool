using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartSchool.Data;
using SmartSchool.Models;

namespace SmartSchool.Controllers {
  [ApiController]
  [Route("api/[controller]")]
  public class StudentController : ControllerBase {
    public  readonly IRepository _repo;
    public StudentController( IRepository repo) {      
      _repo = repo;
    }

    [HttpGet]
    public IActionResult Get(){
      var result = _repo.GetAllStudents(true);

      return Ok(result);
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id){
      var result = _repo.GetStudentById(id, false);
      if(result == null) return BadRequest("Aluno não encontrado!"); 
      
      return Ok(result);
    }

    [HttpPost]
    public IActionResult PostStudent(Student student){
      _repo.Add(student);
      if(_repo.SaveChanges()) {
        return  Ok(student);
      }

      return BadRequest("Aluno não foi cadastrado!");
    }

    [HttpPut("{id}")]
    public IActionResult PutStudent(int id, Student student){
      var studentExists = _repo.GetStudentById(id);
      
      _repo.Update(student);
      if(_repo.SaveChanges()) {
        return  Ok(student);
      } 

      return BadRequest("Aluno não foi cadastrado!");
    }
    
    [HttpPatch("{id}")]
    public IActionResult PatchStudent(int id, Student student){
     var studentExists = _repo.GetStudentById(id);
      
      _repo.Patch(student);
      if(_repo.SaveChanges()) 
        return  Ok(student);

      return BadRequest("Aluno não foi cadastrado!");
    }

    
    [HttpDelete("{id}")]
    public IActionResult DeleteStudent(int id){
     var studentExists = _repo.GetStudentById(id);
      if(studentExists == null) return BadRequest("Aluno não existe!");

      _repo.Delete(studentExists);
      if(_repo.SaveChanges()) 
        return  Ok(studentExists + $"Deletado!");

      return BadRequest("Aluno não foi cadastrado!");
    }
  }
}