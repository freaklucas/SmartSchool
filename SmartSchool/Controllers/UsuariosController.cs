using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartSchool.Data;
using SmartSchool.DTO;
using SmartSchool.Models;
using SmartSchool.Services;

namespace SmartSchool.Controllers
{
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly UsuarioService _usuarioService;
        public UsuariosController(UsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpGet("{id}")]
        public ActionResult<UsuarioDTO> Get(int id)
        {
            int [] valores = {1,2,3,5};
            List <int> numeros = new List<int>();
            numeros.Add(1);
            numeros.Add(2);
            
            if(numeros!=null) {
                foreach(int num in numeros) {
                    Console.WriteLine(num);
                } 
            }

            List<int> array = new List<int> {28, 19, 55};
            int soma = array.Aggregate((v1, num) => v1+num);
            Console.WriteLine("soma: " + soma);
            bool isMaiorIdade = array.All(value => value > 18);
            
            var nomes = new List<string> {"Lucas", "Charlie", "Pedro"};

            foreach(var nome in nomes) {
                Console.WriteLine(nome);
            }
            

            return _usuarioService.GetUsuario(id);
        }

        [HttpGet("LastName")]
        public ActionResult<IEnumerable<UsuarioDTO>> GetByLastName(string lastName)
        {
            if (string.IsNullOrWhiteSpace(lastName))
            {
                return BadRequest("O sobrenome não pode ser vazio.");
            }

            var usuarios = _usuarioService.GetUsuariosByLastName(lastName);

            if (usuarios == null || !usuarios.Any())
            {
                return NotFound("Não existe ninguém com esse sobrenome.");
            }

            var result = usuarios
                .Where(u => u.LastName != null && u.LastName
.Contains(lastName, StringComparison.OrdinalIgnoreCase));

            if (!result.Any())
            {
                return NotFound("Não existe ninguém com esse sobrenome.");
            }

            return Ok(result);
        }

    }
}