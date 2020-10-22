using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication8.Migrations
{
    public partial class qwr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SharedFolders_Files_FolderId",
                table: "SharedFolders");

            migrationBuilder.DropIndex(
                name: "IX_SharedFolders_FolderId",
                table: "SharedFolders");

            migrationBuilder.DropColumn(
                name: "FolderId",
                table: "SharedFolders");

            migrationBuilder.AddColumn<string>(
                name: "OwnerId",
                table: "SharedFolders",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SharedFolderId",
                table: "Files",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SharedFolders_OwnerId",
                table: "SharedFolders",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Files_SharedFolderId",
                table: "Files",
                column: "SharedFolderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Files_SharedFolders_SharedFolderId",
                table: "Files",
                column: "SharedFolderId",
                principalTable: "SharedFolders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SharedFolders_IdentityUser_OwnerId",
                table: "SharedFolders",
                column: "OwnerId",
                principalTable: "IdentityUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Files_SharedFolders_SharedFolderId",
                table: "Files");

            migrationBuilder.DropForeignKey(
                name: "FK_SharedFolders_IdentityUser_OwnerId",
                table: "SharedFolders");

            migrationBuilder.DropIndex(
                name: "IX_SharedFolders_OwnerId",
                table: "SharedFolders");

            migrationBuilder.DropIndex(
                name: "IX_Files_SharedFolderId",
                table: "Files");

            migrationBuilder.DropColumn(
                name: "OwnerId",
                table: "SharedFolders");

            migrationBuilder.DropColumn(
                name: "SharedFolderId",
                table: "Files");

            migrationBuilder.AddColumn<int>(
                name: "FolderId",
                table: "SharedFolders",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SharedFolders_FolderId",
                table: "SharedFolders",
                column: "FolderId");

            migrationBuilder.AddForeignKey(
                name: "FK_SharedFolders_Files_FolderId",
                table: "SharedFolders",
                column: "FolderId",
                principalTable: "Files",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
