using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PainelRotinaEstudos.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Activities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Subject = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Day = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    Time = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activities", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "CreatedAt", "Day", "Description", "Subject", "Time" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 11, 6, 11, 34, 21, 399, DateTimeKind.Local).AddTicks(7345), "SEG", "Matemática Algebra Linear", "MAT23", "3:30" },
                    { 2, new DateTime(2025, 11, 6, 11, 34, 21, 399, DateTimeKind.Local).AddTicks(7348), "SEG", "Programação Desenvolvimento Web", "PDR15a", "PDR15a" },
                    { 3, new DateTime(2025, 11, 6, 11, 34, 21, 399, DateTimeKind.Local).AddTicks(7350), "TER", "Fisica Mecânica", "FIS101", "2:00" },
                    { 4, new DateTime(2025, 11, 6, 11, 34, 21, 399, DateTimeKind.Local).AddTicks(7352), "QUA", "Engenharia de Software", "ENG204", "4:15" },
                    { 5, new DateTime(2025, 11, 6, 11, 34, 21, 399, DateTimeKind.Local).AddTicks(7355), "QUI", "Algoritmos Avançados", "ALG301", "1:30" },
                    { 6, new DateTime(2025, 11, 6, 11, 34, 21, 399, DateTimeKind.Local).AddTicks(7357), "SEX", "Banco de Dados", "BD202", "3:00" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Activities");
        }
    }
}
