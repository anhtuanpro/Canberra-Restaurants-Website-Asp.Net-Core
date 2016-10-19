using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CanberraRestaurants.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UnitResult",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Assignment1Mark = table.Column<string>(nullable: true),
                    Assignment2Mark = table.Column<string>(nullable: true),
                    ExamMark = table.Column<string>(nullable: true),
                    Grade = table.Column<string>(nullable: true),
                    StudentId = table.Column<string>(nullable: true),
                    StudentName = table.Column<string>(nullable: true),
                    TotalMark = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnitResult", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UnitResult");
        }
    }
}
