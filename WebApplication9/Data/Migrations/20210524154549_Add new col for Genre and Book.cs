using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication9.Data.Migrations
{
    public partial class AddnewcolforGenreandBook : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Book",
                newName: "SmallDescription");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Genre",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Genre",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MainDescription",
                table: "Book",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Genre");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Genre");

            migrationBuilder.DropColumn(
                name: "MainDescription",
                table: "Book");

            migrationBuilder.RenameColumn(
                name: "SmallDescription",
                table: "Book",
                newName: "Description");
        }
    }
}
