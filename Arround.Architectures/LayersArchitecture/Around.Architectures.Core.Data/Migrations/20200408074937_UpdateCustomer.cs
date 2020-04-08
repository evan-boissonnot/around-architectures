using Microsoft.EntityFrameworkCore.Migrations;

namespace Around.Architectures.Core.Data.Migrations
{
    public partial class UpdateCustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Customer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Surname",
                table: "Customer",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "Surname",
                table: "Customer");
        }
    }
}
