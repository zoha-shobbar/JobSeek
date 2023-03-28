using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JobSeek.Api.Migrations
{
    /// <inheritdoc />
    public partial class makeparentjobcategorywithoutparent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobCategories_JobCategories_ParentJobCategoryId",
                table: "JobCategories");

            migrationBuilder.DropIndex(
                name: "IX_JobCategories_ParentJobCategoryId",
                table: "JobCategories");

            migrationBuilder.DropColumn(
                name: "ParentJobCategoryId",
                table: "JobCategories");

            migrationBuilder.CreateTable(
                name: "TestEntities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ModificationDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestEntities", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TestEntities");

            migrationBuilder.AddColumn<int>(
                name: "ParentJobCategoryId",
                table: "JobCategories",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_JobCategories_ParentJobCategoryId",
                table: "JobCategories",
                column: "ParentJobCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_JobCategories_JobCategories_ParentJobCategoryId",
                table: "JobCategories",
                column: "ParentJobCategoryId",
                principalTable: "JobCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
