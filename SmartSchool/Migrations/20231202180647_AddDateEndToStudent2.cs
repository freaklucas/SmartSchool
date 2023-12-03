using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartSchool.Migrations
{
    /// <inheritdoc />
    public partial class AddDateEndToStudent2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Ativo",
                table: "Students",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "BirthDate",
                table: "Students",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "Students",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "InitDate",
                table: "Students",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Registration",
                table: "Students",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Ativo", "BirthDate", "EndDate", "InitDate", "Registration" },
                values: new object[] { true, new DateTime(2005, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 12, 2, 15, 6, 47, 152, DateTimeKind.Local).AddTicks(7140), 1 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Ativo", "BirthDate", "EndDate", "InitDate", "Registration" },
                values: new object[] { true, new DateTime(2005, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 12, 2, 15, 6, 47, 152, DateTimeKind.Local).AddTicks(7148), 2 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Ativo", "BirthDate", "EndDate", "InitDate", "Registration" },
                values: new object[] { true, new DateTime(2005, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 12, 2, 15, 6, 47, 152, DateTimeKind.Local).AddTicks(7151), 3 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Ativo", "BirthDate", "EndDate", "InitDate", "Registration" },
                values: new object[] { true, new DateTime(2005, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 12, 2, 15, 6, 47, 152, DateTimeKind.Local).AddTicks(7154), 4 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Ativo", "BirthDate", "EndDate", "InitDate", "Registration" },
                values: new object[] { true, new DateTime(2005, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 12, 2, 15, 6, 47, 152, DateTimeKind.Local).AddTicks(7158), 5 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Ativo", "BirthDate", "EndDate", "InitDate", "Registration" },
                values: new object[] { true, new DateTime(2005, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 12, 2, 15, 6, 47, 152, DateTimeKind.Local).AddTicks(7162), 6 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Ativo", "BirthDate", "EndDate", "InitDate", "Registration" },
                values: new object[] { true, new DateTime(2005, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 12, 2, 15, 6, 47, 152, DateTimeKind.Local).AddTicks(7165), 7 });

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 2, 1 },
                column: "DateInit",
                value: new DateTime(2023, 12, 2, 15, 6, 47, 152, DateTimeKind.Local).AddTicks(7187));

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 4, 1 },
                column: "DateInit",
                value: new DateTime(2023, 12, 2, 15, 6, 47, 152, DateTimeKind.Local).AddTicks(7189));

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 5, 1 },
                column: "DateInit",
                value: new DateTime(2023, 12, 2, 15, 6, 47, 152, DateTimeKind.Local).AddTicks(7190));

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 1, 2 },
                column: "DateInit",
                value: new DateTime(2023, 12, 2, 15, 6, 47, 152, DateTimeKind.Local).AddTicks(7191));

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 2, 2 },
                column: "DateInit",
                value: new DateTime(2023, 12, 2, 15, 6, 47, 152, DateTimeKind.Local).AddTicks(7192));

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 5, 2 },
                column: "DateInit",
                value: new DateTime(2023, 12, 2, 15, 6, 47, 152, DateTimeKind.Local).AddTicks(7229));

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 1, 3 },
                column: "DateInit",
                value: new DateTime(2023, 12, 2, 15, 6, 47, 152, DateTimeKind.Local).AddTicks(7230));

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 2, 3 },
                column: "DateInit",
                value: new DateTime(2023, 12, 2, 15, 6, 47, 152, DateTimeKind.Local).AddTicks(7231));

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 3, 3 },
                column: "DateInit",
                value: new DateTime(2023, 12, 2, 15, 6, 47, 152, DateTimeKind.Local).AddTicks(7231));

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 1, 4 },
                column: "DateInit",
                value: new DateTime(2023, 12, 2, 15, 6, 47, 152, DateTimeKind.Local).AddTicks(7233));

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 4, 4 },
                column: "DateInit",
                value: new DateTime(2023, 12, 2, 15, 6, 47, 152, DateTimeKind.Local).AddTicks(7234));

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 5, 4 },
                column: "DateInit",
                value: new DateTime(2023, 12, 2, 15, 6, 47, 152, DateTimeKind.Local).AddTicks(7235));

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 4, 5 },
                column: "DateInit",
                value: new DateTime(2023, 12, 2, 15, 6, 47, 152, DateTimeKind.Local).AddTicks(7235));

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 5, 5 },
                column: "DateInit",
                value: new DateTime(2023, 12, 2, 15, 6, 47, 152, DateTimeKind.Local).AddTicks(7236));

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 1, 6 },
                column: "DateInit",
                value: new DateTime(2023, 12, 2, 15, 6, 47, 152, DateTimeKind.Local).AddTicks(7237));

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 2, 6 },
                column: "DateInit",
                value: new DateTime(2023, 12, 2, 15, 6, 47, 152, DateTimeKind.Local).AddTicks(7238));

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 3, 6 },
                column: "DateInit",
                value: new DateTime(2023, 12, 2, 15, 6, 47, 152, DateTimeKind.Local).AddTicks(7238));

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 4, 6 },
                column: "DateInit",
                value: new DateTime(2023, 12, 2, 15, 6, 47, 152, DateTimeKind.Local).AddTicks(7240));

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 1, 7 },
                column: "DateInit",
                value: new DateTime(2023, 12, 2, 15, 6, 47, 152, DateTimeKind.Local).AddTicks(7241));

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 2, 7 },
                column: "DateInit",
                value: new DateTime(2023, 12, 2, 15, 6, 47, 152, DateTimeKind.Local).AddTicks(7242));

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 3, 7 },
                column: "DateInit",
                value: new DateTime(2023, 12, 2, 15, 6, 47, 152, DateTimeKind.Local).AddTicks(7242));

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 4, 7 },
                column: "DateInit",
                value: new DateTime(2023, 12, 2, 15, 6, 47, 152, DateTimeKind.Local).AddTicks(7243));

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 5, 7 },
                column: "DateInit",
                value: new DateTime(2023, 12, 2, 15, 6, 47, 152, DateTimeKind.Local).AddTicks(7244));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 1,
                column: "InitDate",
                value: new DateTime(2023, 12, 2, 15, 6, 47, 152, DateTimeKind.Local).AddTicks(6758));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 2,
                column: "InitDate",
                value: new DateTime(2023, 12, 2, 15, 6, 47, 152, DateTimeKind.Local).AddTicks(6773));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 3,
                column: "InitDate",
                value: new DateTime(2023, 12, 2, 15, 6, 47, 152, DateTimeKind.Local).AddTicks(6774));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 4,
                column: "InitDate",
                value: new DateTime(2023, 12, 2, 15, 6, 47, 152, DateTimeKind.Local).AddTicks(6775));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 5,
                column: "InitDate",
                value: new DateTime(2023, 12, 2, 15, 6, 47, 152, DateTimeKind.Local).AddTicks(6776));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ativo",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "BirthDate",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "InitDate",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Registration",
                table: "Students");

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 2, 1 },
                column: "DateInit",
                value: new DateTime(2023, 12, 2, 14, 35, 21, 828, DateTimeKind.Local).AddTicks(6103));

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 4, 1 },
                column: "DateInit",
                value: new DateTime(2023, 12, 2, 14, 35, 21, 828, DateTimeKind.Local).AddTicks(6111));

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 5, 1 },
                column: "DateInit",
                value: new DateTime(2023, 12, 2, 14, 35, 21, 828, DateTimeKind.Local).AddTicks(6112));

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 1, 2 },
                column: "DateInit",
                value: new DateTime(2023, 12, 2, 14, 35, 21, 828, DateTimeKind.Local).AddTicks(6113));

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 2, 2 },
                column: "DateInit",
                value: new DateTime(2023, 12, 2, 14, 35, 21, 828, DateTimeKind.Local).AddTicks(6115));

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 5, 2 },
                column: "DateInit",
                value: new DateTime(2023, 12, 2, 14, 35, 21, 828, DateTimeKind.Local).AddTicks(6117));

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 1, 3 },
                column: "DateInit",
                value: new DateTime(2023, 12, 2, 14, 35, 21, 828, DateTimeKind.Local).AddTicks(6118));

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 2, 3 },
                column: "DateInit",
                value: new DateTime(2023, 12, 2, 14, 35, 21, 828, DateTimeKind.Local).AddTicks(6119));

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 3, 3 },
                column: "DateInit",
                value: new DateTime(2023, 12, 2, 14, 35, 21, 828, DateTimeKind.Local).AddTicks(6121));

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 1, 4 },
                column: "DateInit",
                value: new DateTime(2023, 12, 2, 14, 35, 21, 828, DateTimeKind.Local).AddTicks(6123));

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 4, 4 },
                column: "DateInit",
                value: new DateTime(2023, 12, 2, 14, 35, 21, 828, DateTimeKind.Local).AddTicks(6124));

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 5, 4 },
                column: "DateInit",
                value: new DateTime(2023, 12, 2, 14, 35, 21, 828, DateTimeKind.Local).AddTicks(6125));

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 4, 5 },
                column: "DateInit",
                value: new DateTime(2023, 12, 2, 14, 35, 21, 828, DateTimeKind.Local).AddTicks(6126));

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 5, 5 },
                column: "DateInit",
                value: new DateTime(2023, 12, 2, 14, 35, 21, 828, DateTimeKind.Local).AddTicks(6127));

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 1, 6 },
                column: "DateInit",
                value: new DateTime(2023, 12, 2, 14, 35, 21, 828, DateTimeKind.Local).AddTicks(6128));

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 2, 6 },
                column: "DateInit",
                value: new DateTime(2023, 12, 2, 14, 35, 21, 828, DateTimeKind.Local).AddTicks(6130));

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 3, 6 },
                column: "DateInit",
                value: new DateTime(2023, 12, 2, 14, 35, 21, 828, DateTimeKind.Local).AddTicks(6131));

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 4, 6 },
                column: "DateInit",
                value: new DateTime(2023, 12, 2, 14, 35, 21, 828, DateTimeKind.Local).AddTicks(6133));

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 1, 7 },
                column: "DateInit",
                value: new DateTime(2023, 12, 2, 14, 35, 21, 828, DateTimeKind.Local).AddTicks(6134));

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 2, 7 },
                column: "DateInit",
                value: new DateTime(2023, 12, 2, 14, 35, 21, 828, DateTimeKind.Local).AddTicks(6135));

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 3, 7 },
                column: "DateInit",
                value: new DateTime(2023, 12, 2, 14, 35, 21, 828, DateTimeKind.Local).AddTicks(6136));

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 4, 7 },
                column: "DateInit",
                value: new DateTime(2023, 12, 2, 14, 35, 21, 828, DateTimeKind.Local).AddTicks(6137));

            migrationBuilder.UpdateData(
                table: "StudentsDisciplines",
                keyColumns: new[] { "DisciplineId", "StudentId" },
                keyValues: new object[] { 5, 7 },
                column: "DateInit",
                value: new DateTime(2023, 12, 2, 14, 35, 21, 828, DateTimeKind.Local).AddTicks(6138));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 1,
                column: "InitDate",
                value: new DateTime(2023, 12, 2, 14, 35, 21, 828, DateTimeKind.Local).AddTicks(5632));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 2,
                column: "InitDate",
                value: new DateTime(2023, 12, 2, 14, 35, 21, 828, DateTimeKind.Local).AddTicks(5664));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 3,
                column: "InitDate",
                value: new DateTime(2023, 12, 2, 14, 35, 21, 828, DateTimeKind.Local).AddTicks(5666));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 4,
                column: "InitDate",
                value: new DateTime(2023, 12, 2, 14, 35, 21, 828, DateTimeKind.Local).AddTicks(5667));

            migrationBuilder.UpdateData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 5,
                column: "InitDate",
                value: new DateTime(2023, 12, 2, 14, 35, 21, 828, DateTimeKind.Local).AddTicks(5669));
        }
    }
}
