using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication8.Migrations
{
    public partial class SharedFolder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SharedFolderId",
                table: "IdentityUser",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "SharedFolders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FolderId = table.Column<int>(nullable: true),
                    SharedPath = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SharedFolders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SharedFolders_Files_FolderId",
                        column: x => x.FolderId,
                        principalTable: "Files",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_IdentityUser_SharedFolderId",
                table: "IdentityUser",
                column: "SharedFolderId");

            migrationBuilder.CreateIndex(
                name: "IX_SharedFolders_FolderId",
                table: "SharedFolders",
                column: "FolderId");

            migrationBuilder.AddForeignKey(
                name: "FK_IdentityUser_SharedFolders_SharedFolderId",
                table: "IdentityUser",
                column: "SharedFolderId",
                principalTable: "SharedFolders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IdentityUser_SharedFolders_SharedFolderId",
                table: "IdentityUser");

            migrationBuilder.DropTable(
                name: "SharedFolders");

            migrationBuilder.DropIndex(
                name: "IX_IdentityUser_SharedFolderId",
                table: "IdentityUser");

            migrationBuilder.DropColumn(
                name: "SharedFolderId",
                table: "IdentityUser");
        }
    }
}
