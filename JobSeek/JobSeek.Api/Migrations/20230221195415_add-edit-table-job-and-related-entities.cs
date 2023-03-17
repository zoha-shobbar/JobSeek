using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JobSeek.Api.Migrations
{
    /// <inheritdoc />
    public partial class addedittablejobandrelatedentities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TestEntities");

            migrationBuilder.RenameColumn(
                name: "MajoringIn",
                table: "users",
                newName: "SeniorityLevel");

            migrationBuilder.RenameColumn(
                name: "Degree",
                table: "users",
                newName: "Education");

            migrationBuilder.RenameColumn(
                name: "Degree",
                table: "Jobs",
                newName: "Education");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SeniorityLevel",
                table: "users",
                newName: "MajoringIn");

            migrationBuilder.RenameColumn(
                name: "Education",
                table: "users",
                newName: "Degree");

            migrationBuilder.RenameColumn(
                name: "Education",
                table: "Jobs",
                newName: "Degree");

            migrationBuilder.CreateTable(
                name: "TestEntities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreationDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ModificationDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestEntities", x => x.Id);
                });
        }
    }
}
