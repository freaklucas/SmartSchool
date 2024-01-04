using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartSchool.Data;
using SmartSchool.DTO;
using SmartSchool.Models;

namespace SmartSchool.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TeacherController : ControllerBase
{
    public readonly IRepository _repo;
    public readonly IMapper _mapper;

    public TeacherController(IRepository repo, IMapper mapper)
    {
        _repo = repo;
        _mapper = mapper;
    }

    [HttpGet]
    public IActionResult Get()
    {
        var result = _repo.GetAllTeachers(true);

        return Ok(_mapper.Map<IEnumerable<TeacherDTO>>(result));
    }


    [HttpGet("Testando")]
    public IActionResult GetTeste()
    {
        return Ok(new TeacherRegisterDTO());
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var result = _repo.GetTeacherById(id, false);
        if (result == null) return BadRequest("Professor não encontrado!");

        var teacherDto = _mapper.Map<TeacherDTO>(result);

        return Ok(teacherDto);
    }

    // TODO: Fazer no post, put e patch
    [HttpPost]
    public IActionResult PostTeacher(TeacherRegisterDTO model)
    {
        var teacher = _mapper.Map<TeacherDTO>(model);

        _repo.Add(teacher);
        if (_repo.SaveChanges()) return Created($"/api/teacher/{model.Id}", _mapper.Map<TeacherDTO>(teacher));
        return BadRequest("Professor não foi cadastrado!");
    }

    [HttpPut("{id}")]
    public IActionResult PutTeacher(int id, TeacherRegisterDTO model)
    {
        var teacherExists = _repo.GetTeacherById(id);
        if (teacherExists == null) return BadRequest("Professor não existe!");
        _mapper.Map(model, teacherExists);

        _repo.Update(teacherExists);
        if (_repo.SaveChanges()) return Created($"/api/teacher/{model.Id}", _mapper.Map<TeacherDTO>(teacherExists));

        return BadRequest("Professor não atualizado!");
    }

    [HttpPatch("{id}")]
    public IActionResult PatchTeacher(int id, TeacherRegisterDTO model)
    {
        var teacherExists = _repo.GetTeacherById(id);
        _mapper.Map(model, teacherExists);
        _repo.Patch(teacherExists);

        if (_repo.SaveChanges()) return Created($"/api/teacher/{model.Id}", _mapper.Map<TeacherDTO>(teacherExists));

        return BadRequest("Professor não atualizado!");
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteTeacher(int id)
    {
        var teacherExists = _repo.GetTeacherById(id, false);
        if (teacherExists == null) return BadRequest("Professor não existe!");

        _repo.Delete(teacherExists);
        if (_repo.SaveChanges()) return Ok(teacherExists + $"Deletado!");

        return BadRequest("Professor não deletado!");
    }
}