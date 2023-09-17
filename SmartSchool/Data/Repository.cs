using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SmartSchool.Models;

namespace SmartSchool.Data
{
  public class Repository : IRepository
  {
    private readonly SmartContext _context;
    public Repository(SmartContext context)
    {
      _context = context;
    }
    public void Add<T>(T entity) where T : class
    {
      _context.Add(entity);
    }
    public void Update<T>(T entity) where T : class
    {
      _context.Update(entity);
    }
    public void Patch<T>(T entity) where T : class
    {
      _context.Update(entity);
    }
    public void Delete<T>(T entity) where T : class
    {
      _context.Remove(entity);
    }

    public Student[] GetAllStudents(bool includeTeacher = false)
    {
      IQueryable<Student> query = _context.Students;
      if (includeTeacher)
      {
        query = query.Include(s => s.StudentsDisciplines)
                .ThenInclude(ad => ad.Discipline)
                .ThenInclude(dp => dp.Teacher);
      }
      query = query.AsNoTracking().OrderBy(s => s.Id);

      return query.ToArray();
    }

    public Student[] GetAllStudentsByDisciplineId(int studentId, bool includeTeacher = false)
    {
      IQueryable<Student> query = _context.Students;
      if (includeTeacher)
      {
        query = query.Include(s => s.StudentsDisciplines)
                .ThenInclude(ad => ad.Discipline)
                .ThenInclude(dp => dp.Teacher);
      }
      query = query.AsNoTracking()
                   .OrderBy(s => s.Id)
                   .Where(
                      student => student.StudentsDisciplines
                    .Any(sd => sd.DisciplineId == studentId));

      return query.ToArray();
    }

    public Student GetStudentById(int studentId, bool includeTeacher = false)
    {
      IQueryable<Student> query = _context.Students;
      if (includeTeacher)
      {
        query = query.Include(s => s.StudentsDisciplines)
                .ThenInclude(ad => ad.Discipline)
                .ThenInclude(dp => dp.Teacher);
      }
      query = query.AsNoTracking()
                   .OrderBy(s => s.Id)
                   .Where(student => student.Id == studentId);

      return query.FirstOrDefault();
    }

    public Teacher[] GetAllTeachers(bool includeStudents = false)
    {
      IQueryable<Teacher> query = _context.Teachers;
      if (includeStudents)
      {
        query = query.Include(s => s.Disciplines)
                .ThenInclude(d => d.StudentsDisciplines)
                .ThenInclude(ad => ad.Student);
      }
      query = query.AsNoTracking().OrderBy(s => s.Id);

      return query.ToArray();
    }

    public Teacher[] GetAllTeachersByDisciplineId(int disciplineId, bool includeStudents = false)
    {
      IQueryable<Teacher> query = _context.Teachers;
      if (includeStudents)
      {
        query = query.Include(s => s.Disciplines)
                .ThenInclude(d => d.StudentsDisciplines)
                .ThenInclude(ad => ad.Student);
      }
      query = query.AsNoTracking()
                   .OrderBy(al => al.Id)
                   .Where(stud => stud.Disciplines.Any(
                     d => d.StudentsDisciplines.Any(ad => ad.DisciplineId == disciplineId))
                   );

      return query.ToArray();
    }

    public Teacher GetTeacherById(int teacherId, bool includeTeacher = false)
    {
      IQueryable<Teacher> query = _context.Teachers;
      if (includeTeacher)
      {
        query = query.Include(s => s.Disciplines)
                .ThenInclude(d => d.StudentsDisciplines)
                .ThenInclude(ad => ad.Student);
      }
      query = query.AsNoTracking()
                   .OrderBy(al => al.Id)
                   .Where(teac => teac.Id == teacherId);

      return query.FirstOrDefault();
    }

    public bool SaveChanges()
    {
      return _context.SaveChanges() > 0;
    }
  }
}