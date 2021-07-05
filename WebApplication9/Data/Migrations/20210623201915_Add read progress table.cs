using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication9.Data.Migrations
{
    public partial class Addreadprogresstable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ReadProgresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserLibraryId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BookId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CurrentBookPage = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReadProgresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReadProgresses_Book_BookId",
                        column: x => x.BookId,
                        principalTable: "Book",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ReadProgresses_UserLibrary_UserLibraryId",
                        column: x => x.UserLibraryId,
                        principalTable: "UserLibrary",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ReadProgresses_BookId",
                table: "ReadProgresses",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_ReadProgresses_UserLibraryId",
                table: "ReadProgresses",
                column: "UserLibraryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReadProgresses");
        }
    }
}
