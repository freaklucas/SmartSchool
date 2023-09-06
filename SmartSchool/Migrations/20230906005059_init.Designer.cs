﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SmartSchool.Data;

#nullable disable

namespace SmartSchool.Migrations
{
    [DbContext(typeof(SmartContext))]
    [Migration("20230906005059_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.10");

            modelBuilder.Entity("SmartSchool.Models.Discipline", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("TeacherId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("TeacherId");

                    b.ToTable("Disciplines");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Matemática",
                            TeacherId = 1
                        },
                        new
                        {
                            Id = 2,
                            Name = "Física",
                            TeacherId = 2
                        },
                        new
                        {
                            Id = 3,
                            Name = "Português",
                            TeacherId = 3
                        },
                        new
                        {
                            Id = 4,
                            Name = "Inglês",
                            TeacherId = 4
                        },
                        new
                        {
                            Id = 5,
                            Name = "Programação",
                            TeacherId = 5
                        });
                });

            modelBuilder.Entity("SmartSchool.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("NumberPhone")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            LastName = "Kent",
                            Name = "Marta",
                            NumberPhone = "33225555"
                        },
                        new
                        {
                            Id = 2,
                            LastName = "Isabela",
                            Name = "Paula",
                            NumberPhone = "3354288"
                        },
                        new
                        {
                            Id = 3,
                            LastName = "Antonia",
                            Name = "Laura",
                            NumberPhone = "55668899"
                        },
                        new
                        {
                            Id = 4,
                            LastName = "Maria",
                            Name = "Luiza",
                            NumberPhone = "6565659"
                        },
                        new
                        {
                            Id = 5,
                            LastName = "Machado",
                            Name = "Lucas",
                            NumberPhone = "565685415"
                        },
                        new
                        {
                            Id = 6,
                            LastName = "Alvares",
                            Name = "Pedro",
                            NumberPhone = "456454545"
                        },
                        new
                        {
                            Id = 7,
                            LastName = "José",
                            Name = "Paulo",
                            NumberPhone = "9874512"
                        });
                });

            modelBuilder.Entity("SmartSchool.Models.StudentDiscipline", b =>
                {
                    b.Property<int>("StudentId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("DisciplineId")
                        .HasColumnType("INTEGER");

                    b.HasKey("StudentId", "DisciplineId");

                    b.HasIndex("DisciplineId");

                    b.ToTable("StudentsDisciplines");

                    b.HasData(
                        new
                        {
                            StudentId = 1,
                            DisciplineId = 2
                        },
                        new
                        {
                            StudentId = 1,
                            DisciplineId = 4
                        },
                        new
                        {
                            StudentId = 1,
                            DisciplineId = 5
                        },
                        new
                        {
                            StudentId = 2,
                            DisciplineId = 1
                        },
                        new
                        {
                            StudentId = 2,
                            DisciplineId = 2
                        },
                        new
                        {
                            StudentId = 2,
                            DisciplineId = 5
                        },
                        new
                        {
                            StudentId = 3,
                            DisciplineId = 1
                        },
                        new
                        {
                            StudentId = 3,
                            DisciplineId = 2
                        },
                        new
                        {
                            StudentId = 3,
                            DisciplineId = 3
                        },
                        new
                        {
                            StudentId = 4,
                            DisciplineId = 1
                        },
                        new
                        {
                            StudentId = 4,
                            DisciplineId = 4
                        },
                        new
                        {
                            StudentId = 4,
                            DisciplineId = 5
                        },
                        new
                        {
                            StudentId = 5,
                            DisciplineId = 4
                        },
                        new
                        {
                            StudentId = 5,
                            DisciplineId = 5
                        },
                        new
                        {
                            StudentId = 6,
                            DisciplineId = 1
                        },
                        new
                        {
                            StudentId = 6,
                            DisciplineId = 2
                        },
                        new
                        {
                            StudentId = 6,
                            DisciplineId = 3
                        },
                        new
                        {
                            StudentId = 6,
                            DisciplineId = 4
                        },
                        new
                        {
                            StudentId = 7,
                            DisciplineId = 1
                        },
                        new
                        {
                            StudentId = 7,
                            DisciplineId = 2
                        },
                        new
                        {
                            StudentId = 7,
                            DisciplineId = 3
                        },
                        new
                        {
                            StudentId = 7,
                            DisciplineId = 4
                        },
                        new
                        {
                            StudentId = 7,
                            DisciplineId = 5
                        });
                });

            modelBuilder.Entity("SmartSchool.Models.Teacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Teachers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Lauro"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Roberto"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Ronaldo"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Rodrigo"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Alexandre"
                        });
                });

            modelBuilder.Entity("SmartSchool.Models.Discipline", b =>
                {
                    b.HasOne("SmartSchool.Models.Teacher", "Teacher")
                        .WithMany("Disciplines")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("SmartSchool.Models.StudentDiscipline", b =>
                {
                    b.HasOne("SmartSchool.Models.Discipline", "Discipline")
                        .WithMany("StudentsDisciplines")
                        .HasForeignKey("DisciplineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SmartSchool.Models.Student", "Student")
                        .WithMany("StudentsDisciplines")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Discipline");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("SmartSchool.Models.Discipline", b =>
                {
                    b.Navigation("StudentsDisciplines");
                });

            modelBuilder.Entity("SmartSchool.Models.Student", b =>
                {
                    b.Navigation("StudentsDisciplines");
                });

            modelBuilder.Entity("SmartSchool.Models.Teacher", b =>
                {
                    b.Navigation("Disciplines");
                });
#pragma warning restore 612, 618
        }
    }
}
