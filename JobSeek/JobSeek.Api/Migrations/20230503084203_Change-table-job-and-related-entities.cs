using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JobSeek.Api.Migrations
{
    /// <inheritdoc />
    public partial class Changetablejobandrelatedentities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "companyLicenseNumber",
                table: "users",
                newName: "CompanyLicenseNumber");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CompanyLicenseNumber",
                table: "users",
                newName: "companyLicenseNumber");
        }
    }
}
