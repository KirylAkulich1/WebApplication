using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication8.Migrations
{
    public partial class qwerty123 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SharedFolders_IdentityUser_OwnerId",
                table: "SharedFolders");

            migrationBuilder.DropIndex(
                name: "IX_SharedFolders_OwnerId",
                table: "SharedFolders");

            migrationBuilder.DropColumn(
                name: "OwnerId",
                table: "SharedFolders");

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "SharedFolders",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserName",
                table: "SharedFolders");

            migrationBuilder.AddColumn<string>(
                name: "OwnerId",
                table: "SharedFolders",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SharedFolders_OwnerId",
                table: "SharedFolders",
                column: "OwnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_SharedFolders_IdentityUser_OwnerId",
                table: "SharedFolders",
                column: "OwnerId",
                principalTable: "IdentityUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
