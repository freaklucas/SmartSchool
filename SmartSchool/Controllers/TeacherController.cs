using Microsoft.AspNetCore.Mvc;
using SmartSchool.Models;

namespace SmartSchool.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TeacherController : ControllerBase
    {
        public List<Teacher> TeachersList = new List<Teacher>() {
        new Teacher()
        {
            Id = 1,
            Name = "Edvilso"
        },
        new Teacher()
        {
            Id = 2,
            Name = "Dagoberto"
        }
    };
        public TeacherController() { }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(TeachersList);
            }
            catch (Exception ex)
            {
                Console.Write(ex.ToString());
                return BadRequest();
            }
        }


    }
}