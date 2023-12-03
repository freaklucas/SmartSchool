using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SmartSchool.Migrations
{
    /// <inheritdoc />
    public partial class AddDateEndToStudent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Ativo",
                table: "Teachers",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "Teachers",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "InitDate",
                table: "Teachers",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Teachers",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NumberPhone",
                table: "Teachers",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Registration",
                table: "Teachers",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateEnd",
                table: "StudentsDisciplines",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateInit",
                table: "StudentsDisciplines",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "ValueNote",
                table: "StudentsDisciplines",
                type: "INTEGER",
                nullable: true);
            
            migrationBuilder.AddColumn<DateTime>(
                name: "DateEnd",
                table: "Students",
                type: "datetime2",
                nullable: true
            );

            migrationBuilder.AlterColumn<string>(
                name: "NumberPhone",
                table: "Students",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AddColumn<int>(
                name: "CargaHoraria",
                table: "Disciplines",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CourseId",
                table: "Disciplines",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PreRequisitId",
                table: "Disciplines",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StudentsCourse",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "INTEGER", nullable: false),
                    CourseId = table.Column<int>(type: "INTEGER", nullable: false),
                    DisciplineId = table.Column<int>(type: "INTEGER", nullable: false),
                    DateInit = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DateEnd = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentsCourse", x => new { x.StudentId, x.CourseId });
                    table.ForeignKey(
                        name: "FK_StudentsCourse_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentsCourse_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Tecnologia da Informação" },
                    { 2, "Sistemas de Informação" },
                    { 3, "Ciência da Computação" }
                });

            migrationBuilder.UpdateData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CargaHoraria", "CourseId", "PreRequisitId" },
                values: new object[] { 0, 1, null });

            migrationBuilder.UpdateData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CargaHoraria", "CourseId", "Name", "PreRequisitId", "TeacherId" },
                values: new object[] { 0, 3, "Matemática", null, 1 });

            migrationBuilder.UpdateData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CargaHoraria", "CourseId", "Name", "PreRequisitId", "TeacherId" },
                values: new object[] { 0, 3, "Física", null, 2 });

            migrationBuilder.UpdateData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CargaHoraria", "CourseId", "Name", "PreRequisitId", "TeacherId" },
                values: new object[] { 0, 1, "Português", null, 3 });

            migrationBuilder.UpdateData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CargaHoraria", "CourseId", "Name", "PreRequisitId", "TeacherId" },
                values: new object[] { 0, 1, "Inglês", null, 4 });

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 2, 1 },
                columns: new[] { "DateEnd", "DateInit", "ValueNote" },
                values: new object[] { null, new DateTime(2023, 12, 2, 14, 35, 21, 828, DateTimeKind.Local).AddTicks(6103), null });

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 4, 1 },
                columns: new[] { "DateEnd", "DateInit", "ValueNote" },
                values: new object[] { null, new DateTime(2023, 12, 2, 14, 35, 21, 828, DateTimeKind.Local).AddTicks(6111), null });

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 5, 1 },
                columns: new[] { "DateEnd", "DateInit", "ValueNote" },
                values: new object[] { null, new DateTime(2023, 12, 2, 14, 35, 21, 828, DateTimeKind.Local).AddTicks(6112), null });

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 1, 2 },
                columns: new[] { "DateEnd", "DateInit", "ValueNote" },
                values: new object[] { null, new DateTime(2023, 12, 2, 14, 35, 21, 828, DateTimeKind.Local).AddTicks(6113), null });

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 2, 2 },
                columns: new[] { "DateEnd", "DateInit", "ValueNote" },
                values: new object[] { null, new DateTime(2023, 12, 2, 14, 35, 21, 828, DateTimeKind.Local).AddTicks(6115), null });

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 5, 2 },
                columns: new[] { "DateEnd", "DateInit", "ValueNote" },
                values: new object[] { null, new DateTime(2023, 12, 2, 14, 35, 21, 828, DateTimeKind.Local).AddTicks(6117), null });

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 1, 3 },
                columns: new[] { "DateEnd", "DateInit", "ValueNote" },
                values: new object[] { null, new DateTime(2023, 12, 2, 14, 35, 21, 828, DateTimeKind.Local).AddTicks(6118), null });

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 2, 3 },
                columns: new[] { "DateEnd", "DateInit", "ValueNote" },
                values: new object[] { null, new DateTime(2023, 12, 2, 14, 35, 21, 828, DateTimeKind.Local).AddTicks(6119), null });

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 3, 3 },
                columns: new[] { "DateEnd", "DateInit", "ValueNote" },
                values: new object[] { null, new DateTime(2023, 12, 2, 14, 35, 21, 828, DateTimeKind.Local).AddTicks(6121), null });

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 1, 4 },
                columns: new[] { "DateEnd", "DateInit", "ValueNote" },
                values: new object[] { null, new DateTime(2023, 12, 2, 14, 35, 21, 828, DateTimeKind.Local).AddTicks(6123), null });

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 4, 4 },
                columns: new[] { "DateEnd", "DateInit", "ValueNote" },
                values: new object[] { null, new DateTime(2023, 12, 2, 14, 35, 21, 828, DateTimeKind.Local).AddTicks(6124), null });

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 5, 4 },
                columns: new[] { "DateEnd", "DateInit", "ValueNote" },
                values: new object[] { null, new DateTime(2023, 12, 2, 14, 35, 21, 828, DateTimeKind.Local).AddTicks(6125), null });

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 4, 5 },
                columns: new[] { "DateEnd", "DateInit", "ValueNote" },
                values: new object[] { null, new DateTime(2023, 12, 2, 14, 35, 21, 828, DateTimeKind.Local).AddTicks(6126), null });

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 5, 5 },
                columns: new[] { "DateEnd", "DateInit", "ValueNote" },
                values: new object[] { null, new DateTime(2023, 12, 2, 14, 35, 21, 828, DateTimeKind.Local).AddTicks(6127), null });

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 1, 6 },
                columns: new[] { "DateEnd", "DateInit", "ValueNote" },
                values: new object[] { null, new DateTime(2023, 12, 2, 14, 35, 21, 828, DateTimeKind.Local).AddTicks(6128), null });

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 2, 6 },
                columns: new[] { "DateEnd", "DateInit", "ValueNote" },
                values: new object[] { null, new DateTime(2023, 12, 2, 14, 35, 21, 828, DateTimeKind.Local).AddTicks(6130), null });

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 3, 6 },
                columns: new[] { "DateEnd", "DateInit", "ValueNote" },
                values: new object[] { null, new DateTime(2023, 12, 2, 14, 35, 21, 828, DateTimeKind.Local).AddTicks(6131), null });

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 4, 6 },
                columns: new[] { "DateEnd", "DateInit", "ValueNote" },
                values: new object[] { null, new DateTime(2023, 12, 2, 14, 35, 21, 828, DateTimeKind.Local).AddTicks(6133), null });

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 1, 7 },
                columns: new[] { "DateEnd", "DateInit", "ValueNote" },
                values: new object[] { null, new DateTime(2023, 12, 2, 14, 35, 21, 828, DateTimeKind.Local).AddTicks(6134), null });

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 2, 7 },
                columns: new[] { "DateEnd", "DateInit", "ValueNote" },
                values: new object[] { null, new DateTime(2023, 12, 2, 14, 35, 21, 828, DateTimeKind.Local).AddTicks(6135), null });

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 3, 7 },
                columns: new[] { "DateEnd", "DateInit", "ValueNote" },
                values: new object[] { null, new DateTime(2023, 12, 2, 14, 35, 21, 828, DateTimeKind.Local).AddTicks(6136), null });

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 4, 7 },
                columns: new[] { "DateEnd", "DateInit", "ValueNote" },
                values: new object[] { null, new DateTime(2023, 12, 2, 14, 35, 21, 828, DateTimeKind.Local).AddTicks(6137), null });

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 5, 7 },
                columns: new[] { "DateEnd", "DateInit", "ValueNote" },
                values: new object[] { null, new DateTime(2023, 12, 2, 14, 35, 21, 828, DateTimeKind.Local).AddTicks(6138), null });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Ativo", "EndDate", "InitDate", "LastName", "NumberPhone", "Registration" },
                values: new object[] { true, null, new DateTime(2023, 12, 2, 14, 35, 21, 828, DateTimeKind.Local).AddTicks(5632), "Oliveira", null, 1 });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Ativo", "EndDate", "InitDate", "LastName", "NumberPhone", "Registration" },
                values: new object[] { true, null, new DateTime(2023, 12, 2, 14, 35, 21, 828, DateTimeKind.Local).AddTicks(5664), "Soares", null, 2 });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Ativo", "EndDate", "InitDate", "LastName", "NumberPhone", "Registration" },
                values: new object[] { true, null, new DateTime(2023, 12, 2, 14, 35, 21, 828, DateTimeKind.Local).AddTicks(5666), "Marconi", null, 3 });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Ativo", "EndDate", "InitDate", "LastName", "NumberPhone", "Registration" },
                values: new object[] { true, null, new DateTime(2023, 12, 2, 14, 35, 21, 828, DateTimeKind.Local).AddTicks(5667), "Carvalho", null, 4 });

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Ativo", "EndDate", "InitDate", "LastName", "NumberPhone", "Registration" },
                values: new object[] { true, null, new DateTime(2023, 12, 2, 14, 35, 21, 828, DateTimeKind.Local).AddTicks(5669), "Montanha", null, 5 });

            migrationBuilder.InsertData(
                table: "Disciplines",
                columns: new[] { "Id", "CargaHoraria", "CourseId", "Name", "PreRequisitId", "TeacherId" },
                values: new object[,]
                {
                    { 6, 0, 2, "Inglês", null, 4 },
                    { 7, 0, 3, "Inglês", null, 4 },
                    { 8, 0, 1, "Programação", null, 5 },
                    { 9, 0, 2, "Programação", null, 5 },
                    { 10, 0, 3, "Programação", null, 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Disciplines_CourseId",
                table: "Disciplines",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Disciplines_PreRequisitId",
                table: "Disciplines",
                column: "PreRequisitId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentsCourse_CourseId",
                table: "StudentsCourse",
                column: "CourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Disciplines_Courses_CourseId",
                table: "Disciplines",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Disciplines_Disciplines_PreRequisitId",
                table: "Disciplines",
                column: "PreRequisitId",
                principalTable: "Disciplines",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Disciplines_Courses_CourseId",
                table: "Disciplines");

            migrationBuilder.DropForeignKey(
                name: "FK_Disciplines_Disciplines_PreRequisitId",
                table: "Disciplines");

            migrationBuilder.DropTable(
                name: "StudentsCourse");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Disciplines_CourseId",
                table: "Disciplines");

            migrationBuilder.DropIndex(
                name: "IX_Disciplines_PreRequisitId",
                table: "Disciplines");

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DropColumn(
                name: "Ativo",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "InitDate",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "NumberPhone",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "Registration",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "DateEnd",
                table: "StudentsDisciplines");

            migrationBuilder.DropColumn(
                name: "DateInit",
                table: "StudentsDisciplines");

            migrationBuilder.DropColumn(
                name: "ValueNote",
                table: "StudentsDisciplines");

            migrationBuilder.DropColumn(
                name: "CargaHoraria",
                table: "Disciplines");

            migrationBuilder.DropColumn(
                name: "CourseId",
                table: "Disciplines");

            migrationBuilder.DropColumn(
                name: "PreRequisitId",
                table: "Disciplines");

            migrationBuilder.AlterColumn<string>(
                name: "NumberPhone",
                table: "Students",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Name", "TeacherId" },
                values: new object[] { "Física", 2 });

            migrationBuilder.UpdateData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Name", "TeacherId" },
                values: new object[] { "Português", 3 });

            migrationBuilder.UpdateData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Name", "TeacherId" },
                values: new object[] { "Inglês", 4 });

            migrationBuilder.UpdateData(
                table: "Disciplines",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Name", "TeacherId" },
                values: new object[] { "Programação", 5 });
        }
    }
}
