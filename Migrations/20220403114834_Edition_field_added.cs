using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Test_Series.Migrations
{
    public partial class Edition_field_added : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Edition",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Edition",
                table: "AspNetUsers");
        }
    }
}
