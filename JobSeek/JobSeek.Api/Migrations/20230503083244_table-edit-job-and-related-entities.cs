using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JobSeek.Api.Migrations
{
    /// <inheritdoc />
    public partial class tableeditjobandrelatedentities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CompanyEmployerNumber",
                table: "users");

            migrationBuilder.AddColumn<string>(
                name: "NumberOfCompanyMembers",
                table: "users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "companyLicenseNumber",
                table: "users",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumberOfCompanyMembers",
                table: "users");

            migrationBuilder.DropColumn(
                name: "companyLicenseNumber",
                table: "users");

            migrationBuilder.AddColumn<int>(
                name: "CompanyEmployerNumber",
                table: "users",
                type: "int",
                nullable: true);
        }
    }
}
