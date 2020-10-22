using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication8.Migrations
{
    public partial class AddReq : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AddRequests",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FromId = table.Column<string>(nullable: true),
                    ToId = table.Column<string>(nullable: true),
                    FolderId = table.Column<int>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AddRequests_SharedFolders_FolderId",
                        column: x => x.FolderId,
                        principalTable: "SharedFolders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AddRequests_IdentityUser_FromId",
                        column: x => x.FromId,
                        principalTable: "IdentityUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AddRequests_IdentityUser_ToId",
                        column: x => x.ToId,
                        principalTable: "IdentityUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AddRequests_FolderId",
                table: "AddRequests",
                column: "FolderId");

            migrationBuilder.CreateIndex(
                name: "IX_AddRequests_FromId",
                table: "AddRequests",
                column: "FromId");

            migrationBuilder.CreateIndex(
                name: "IX_AddRequests_ToId",
                table: "AddRequests",
                column: "ToId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AddRequests");
        }
    }
}
