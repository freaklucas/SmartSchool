using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartSchool.Data;
using SmartSchool.DTO;
using SmartSchool.Models;

namespace SmartSchool.Controllers {
  [ApiController]
  [Route("api/[controller]")]
  public class StudentController : ControllerBase {
    public  readonly IRepository _repo;
    public readonly IMapper _mapper;
    public StudentController(IRepository repo, IMapper mapper) {      
      _repo = repo;
      _mapper = mapper;
    }

    [HttpGet]
    public IActionResult Get(){
      var result = _repo.GetAllStudents(true);
      
      return Ok(_mapper.Map<IEnumerable<StudentDTO>>(result));
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id){
      var result = _repo.GetStudentById(id, false);
      if(result == null) return BadRequest("Aluno não encontrado!");

      var studentDto = _mapper.Map<StudentDTO>(result);
      return Ok(studentDto);
    }

    [HttpPost]
    public IActionResult PostStudent(StudentDTO model)
    {
      var student = _mapper.Map<Student>(model);
      
      _repo.Add(student);
      if(_repo.SaveChanges())
      {
        return Created($"/api/student/{model.Id}", _mapper.Map<StudentDTO>(student)); // created = retorna 201 = registro criado
      }

      return BadRequest("Aluno não foi cadastrado!");
    }

    [HttpPut("{id}")]
    public IActionResult PutStudent(int id, StudentDTO model){
      var studentExists = _repo.GetStudentById(id);
      if (studentExists == null) return BadRequest("Estudante não encontrado.");

      _mapper.Map(model, studentExists);
      
      _repo.Update(studentExists);
      if(_repo.SaveChanges()) {
        return Created($"/api/student/{model.Id}", _mapper.Map<StudentDTO>(studentExists));
      } 

      return BadRequest("Aluno não atualizado!");
    }
    
    [HttpPatch("{id}")]
    public IActionResult PatchStudent(int id, StudentDTO model){
     var studentExists = _repo.GetStudentById(id);
     _mapper.Map(model, studentExists);
      
      _repo.Patch(studentExists);
      if (_repo.SaveChanges())
      {
        return Created($"/api/student/{model.Id}", _mapper.Map<StudentDTO>(studentExists));
      }

      return BadRequest("Aluno não foi atualizado!");
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