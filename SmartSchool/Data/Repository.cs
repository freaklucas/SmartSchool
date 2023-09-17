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
        public void Add<T>(T entity) where T : class {
            _context.Add(entity);
        }
        public void Update<T>(T entity) where T : class {
            _context.Update(entity);
        }
        public void Patch<T>(T entity) where T : class {
            _context.Update(entity);
        }
        public void Delete<T>(T entity) where T : class {
            _context.Remove(entity);
        }

        public Student[] GetAllStudents(bool includeDiscipline) {
          IQueryable<Student> query = _context.Students;
          if(includeDiscipline) {
            query = query.Include(s => s.StudentsDisciplines)
                    .ThenInclude(ad => ad.Discipline)
                    .ThenInclude(dp => dp.Teacher);
          }
          query = query.AsNoTracking().OrderBy(s => s.Id);

          return query.ToArray();
        } 
        
        public Student GetStudentsByDisciplineId() {
          throw new System.NotFiniteNumberException("Student is infinite");
        }

        public Student GetStudentById() {
          throw new System.NotFiniteNumberException("Student is infinite");
        }

        public Teacher GetAllTeachers() {
          throw new System.NotFiniteNumberException("Student is infinite");
        }

        public Teacher GetTeachersByDisciplineId() {
          throw new System.NotFiniteNumberException("Student is infinite");
        }

        public Teacher GetTeacherById() {
          throw new System.NotFiniteNumberException("Student is infinite");

        }

        public bool SaveChanges() {
            return _context.SaveChanges() > 0;
        }
    }
}