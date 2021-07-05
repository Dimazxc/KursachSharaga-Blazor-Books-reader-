using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication9.Data.Migrations
{
    public partial class Addnewrelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Book_UserLibrary_UserLibraryId",
                table: "Book");

            migrationBuilder.DropIndex(
                name: "IX_Book_UserLibraryId",
                table: "Book");

            migrationBuilder.DropColumn(
                name: "UserLibraryId",
                table: "Book");

            migrationBuilder.CreateTable(
                name: "BookUserLibrary",
                columns: table => new
                {
                    BooksId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UsersLibrariesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookUserLibrary", x => new { x.BooksId, x.UsersLibrariesId });
                    table.ForeignKey(
                        name: "FK_BookUserLibrary_Book_BooksId",
                        column: x => x.BooksId,
                        principalTable: "Book",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookUserLibrary_UserLibrary_UsersLibrariesId",
                        column: x => x.UsersLibrariesId,
                        principalTable: "UserLibrary",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BookUserLibrary_UsersLibrariesId",
                table: "BookUserLibrary",
                column: "UsersLibrariesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookUserLibrary");

            migrationBuilder.AddColumn<Guid>(
                name: "UserLibraryId",
                table: "Book",
                type: "uniqueidentifier",
                nullable: true);

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
    }
}
