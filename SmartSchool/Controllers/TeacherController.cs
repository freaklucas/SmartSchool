using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartSchool.Data;
using SmartSchool.Models;

namespace SmartSchool.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TeacherController : ControllerBase
    {
        public readonly IRepository _repo;

        public TeacherController(IRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var result = _repo.GetAllTeachers(false);

            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var result = _repo.GetTeacherById(id, false);
            if (result == null) return BadRequest("Professor não encontrado!");

            return Ok(result);
        }

        [HttpPost]
        public IActionResult PostTeacher(Teacher teacher)
        {
            _repo.Add(teacher);
            if (_repo.SaveChanges())
            {
                return Ok(teacher);
            }
            return BadRequest("Professor não foi cadastrado!");

        }

        [HttpPut("{id}")]
        public IActionResult PutTeacher(int id, Teacher teacher)
        {
            var teacherExists = _repo.GetTeacherById(id);

            _repo.Update(teacherExists);
            if(_repo.SaveChanges())  {
                return Ok(teacherExists);
            }

            return BadRequest("Professor não foi cadastrado!");
        }

        [HttpPatch("{id}")]
        public IActionResult PatchTeacher(int id, Teacher teacher)
        {
           var teacherExists = _repo.GetTeacherById(id);

            _repo.Update(teacherExists);
            if(_repo.SaveChanges())  {
                return Ok(teacherExists);
            }

            return BadRequest("Professor não foi cadastrado!");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteTeacher(int id)
        {
            var teacherExists = _repo.GetTeacherById(id);
            if(teacherExists == null) return BadRequest("Professor não existe!");

            _repo.Delete(teacherExists);
            if(_repo.SaveChanges())  {
                return Ok(teacherExists + $"Deletado!");
            }

            return BadRequest("Professor não foi cadastrado!");
        }
    }
}