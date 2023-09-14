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

        Student[] GetAllStudents();
        Student[] GetStudentsByDisciplineId();
        Student GetStudentById();

        Teacher[] GetAllTeachers();
        Teacher[] GetTeachersByDisciplineId();
        Teacher GetTeacherById();


    }
}