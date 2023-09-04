using Microsoft.EntityFrameworkCore;
using SmartSchool.Models;

namespace SmartSchool.Data {
  public class SmartContext : DbContext {
    public SmartContext(DbContextOptions <SmartContext> options) : base(options) {}
    public DbSet <Student> Students { get; set; }
    public DbSet <Teacher> Teachers { get; set; }
    public DbSet <Discipline> Disciplines { get; set; }
    public DbSet <StudentDiscipline> StudentsDisciplines { get; set; }

    protected override void OnModelCreating(ModelBuilder builder) {
      builder.Entity<StudentDiscipline>().HasKey(AD => new {AD.StudentId, AD.DisciplineId}); // relacao mts pra mts
    }
  }
}