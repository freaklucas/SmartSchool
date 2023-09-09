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
        public TeacherController(SmartContext context) {
            _context = context;
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
                _context.Add(teacher);
                _context.SaveChanges();

                return Ok(teacher); 
            }
            catch(Exception e) {
                Console.WriteLine(e.ToString());

                throw;
            }
        }

        [HttpPut("{id}")]
        public IActionResult PutTeacher(int id, Teacher teacher) {
            try
            {
                var teacherSearch = _context.Teachers.AsNoTracking().FirstOrDefault(
                    t => t.Id == id
                );
                if(teacherSearch == null) return BadRequest("Professor não existe!");

                _context.Update(teacher);
                _context.SaveChanges();

                return Ok(teacher);
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
                var teacherSearch = _context.Teachers.AsNoTracking().FirstOrDefault(
                    t => t.Id == id
                );
                if(teacherSearch == null) return BadRequest("Professor não existe!");

                _context.Update(teacher);
                _context.SaveChanges();

                return Ok(teacher);
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
                var teacherSearch = _context.Teachers.AsNoTracking().FirstOrDefault(
                    t => t.Id == id
                );
                if(teacherSearch == null) return BadRequest("Professor não existe!");

                _context.Remove(teacherSearch);
                _context.SaveChanges();

                return Ok(teacherSearch);
            }
            catch (System.Exception)
            {
                throw;
            }
        }
    }
}