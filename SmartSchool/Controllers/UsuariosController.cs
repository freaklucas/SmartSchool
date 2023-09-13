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
        public ActionResult <UsuarioDTO> Get(int id) {
            return _usuarioService.GetUsuario(id);
        }

[HttpGet("LastName")]
public ActionResult<IEnumerable<UsuarioDTO>> GetByLastName(string lastName) {
    var usuarios = _usuarioService.GetUsuariosByLastName(lastName);
    if(usuarios != null && usuarios.Any())
        return Ok(usuarios);
    return NotFound("Nao existe ngm com nome igual!");
}

    }
}