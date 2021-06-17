using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication9.Data.Migrations
{
    public partial class UserLibrarytable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "UserLibraryId",
                table: "Book",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "UserLibrary",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLibrary", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Book_UserLibraryId",
                table: "Book",
                column: "UserLibraryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Book_UserLibrary_UserLibraryId",
                table: "Book",
                column: "UserLibraryId",
                principalTable: "UserLibrary",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Book_UserLibrary_UserLibraryId",
                table: "Book");

            migrationBuilder.DropTable(
                name: "UserLibrary");

            migrationBuilder.DropIndex(
                name: "IX_Book_UserLibraryId",
                table: "Book");

            migrationBuilder.DropColumn(
                name: "UserLibraryId",
                table: "Book");
        }
    }
}
