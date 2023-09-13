using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartSchool.Data;
using SmartSchool.DTO;

namespace SmartSchool.Services
{
    public class UsuarioService
    {
        private readonly SmartContext _context;
        public UsuarioService(SmartContext context)
        {
            _context = context;
        }

        public UsuarioDTO GetUsuario(int id)
        {
            var student = _context.Students.Find(id);
            if (student == null)
                return null;

            var usuarioDTO = new UsuarioDTO
            {
                Name = student.Name,
                LastName = student.LastName
            };

            return usuarioDTO;
        }

        public IEnumerable<UsuarioDTO> GetUsuariosByLastName(string lastName)
        {
            var students = _context.Students.Where(s => s.LastName.ToLower() == lastName.ToLower()).ToList();

            var usuariosDTO = students.Select(student => new UsuarioDTO
            {
                Name = student.Name,
                LastName = student.LastName
            }).ToList();

            return usuariosDTO;
        }


    }
}