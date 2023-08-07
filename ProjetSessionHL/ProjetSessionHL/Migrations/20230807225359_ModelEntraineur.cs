using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetSessionHL.Migrations
{
    public partial class ModelEntraineur : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Alias",
                table: "Entraineurs",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Alias",
                table: "Entraineurs");
        }
    }
}
