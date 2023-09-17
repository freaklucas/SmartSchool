using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartSchool.Models;

namespace SmartSchool.Data
{
    public interface IRepository
    {
        void Add<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        void Patch<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        bool SaveChanges();

        Student[] GetAllStudents(bool includeTeacher = false);
        Student[] GetAllStudentsByDisciplineId(int studentId, bool includeTeacher = false);
        Student GetStudentById(int studentId, bool includeTeacher = false);

        Teacher[] GetAllTeachers(bool includeStudents = false);
        Teacher[] GetAllTeachersByDisciplineId(int disciplineId, bool includeStudents = false);
        Teacher GetTeacherById(int teacherId, bool includeTeacher = false);

    }
}