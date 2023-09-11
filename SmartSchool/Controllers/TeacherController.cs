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
        private readonly SmartContext _context; 
        public  readonly IRepository _repo;

        public TeacherController(SmartContext context, IRepository repo) {
            _context = context;
            _repo = repo;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_context.Teachers);
            }
            catch (Exception ex)
            {
                Console.Write(ex.ToString());
                return BadRequest("Não existem professores!");
            }
        }

        [HttpGet("byId/{id}")]
        public IActionResult GetById(int id) {
            try
            {
                var teacher = _context.Teachers.FirstOrDefault(t => t.Id == id);
                if(teacher == null) return BadRequest("Professor não existe!");

                return Ok(teacher);
            }
            catch (System.Exception)
            {
                
                throw;
            }
        }

        [HttpGet("byName")]
        public IActionResult GetByName(string name) {
            try {
                var teacher = _context.Teachers.FirstOrDefault(
                    t => t.Name.Contains(name)
                );
                if(teacher == null) return BadRequest("Professor não existe!");

                return Ok(teacher);
            }

            catch (System.Exception)
            {
                
                throw;
            }
        }

        [HttpPost]
        public IActionResult PostTeacher(Teacher teacher) {
            try {
                _repo.Add(teacher);
            if(_repo.SaveChanges()) {
                return  Ok(teacher);
            }
            return BadRequest("Aluno não foi cadastrado!");
            }
            catch (Exception ex) {
                Console.WriteLine(ex);
                
                throw;
            }
        }

        [HttpPut("{id}")]
        public IActionResult PutTeacher(int id, Teacher teacher) {
            try
            {
                var teacherSearch = _context.Teachers
                    .AsNoTracking()
                    .FirstOrDefault(
                    t => t.Id == id
                );
                if(teacherSearch == null) return BadRequest("Professor não existe!");
                
                _repo.Update(teacher);
                if(_repo.SaveChanges()) {
                    return  Ok(teacher);
                }

                return BadRequest("Professor não foi cadastrado!");
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        [HttpPatch("{id}")]
        public IActionResult PatchTeacher(int id, Teacher teacher) {
            try
            {
                var teacherSearch = _context.Teachers
                    .AsNoTracking()
                    .FirstOrDefault(
                    t => t.Id == id
                );
                if(teacherSearch == null) return BadRequest("Professor não existe!");
                _repo.Patch(teacher);
                if(_repo.SaveChanges()) {
                    return  Ok(teacher);
                } 

                return BadRequest("Professor não foi cadastrado!");
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteTeacher(int id) {
            try
            {
                var teacherSearch = _context.Teachers
                    .AsNoTracking()
                    .FirstOrDefault(
                    t => t.Id == id
                );
                if(teacherSearch == null) return BadRequest("Professor não existe!");
                _repo.Delete(teacherSearch);
                if(_repo.SaveChanges()) {
                    return Ok(teacherSearch);
                } 

                return BadRequest("Professor não foi cadastrado!");
            }
            catch (System.Exception)
            {
                throw;
            }
        }
    }
}