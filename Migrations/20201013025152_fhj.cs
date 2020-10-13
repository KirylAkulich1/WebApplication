using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication8.Migrations
{
    public partial class fhj : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reports_IdentityUser_SenderId",
                table: "Reports");

            migrationBuilder.DropForeignKey(
                name: "FK_Reports_IdentityUser_ToUserId",
                table: "Reports");

            migrationBuilder.DropIndex(
                name: "IX_Reports_SenderId",
                table: "Reports");

            migrationBuilder.DropIndex(
                name: "IX_Reports_ToUserId",
                table: "Reports");

            migrationBuilder.DropColumn(
                name: "SenderId",
                table: "Reports");

            migrationBuilder.DropColumn(
                name: "ToUserId",
                table: "Reports");

            migrationBuilder.AddColumn<string>(
                name: "IdentityUserId",
                table: "Reports",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Reports",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reports_IdentityUserId",
                table: "Reports",
                column: "IdentityUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reports_IdentityUser_IdentityUserId",
                table: "Reports",
                column: "IdentityUserId",
                principalTable: "IdentityUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reports_IdentityUser_IdentityUserId",
                table: "Reports");

            migrationBuilder.DropIndex(
                name: "IX_Reports_IdentityUserId",
                table: "Reports");

            migrationBuilder.DropColumn(
                name: "IdentityUserId",
                table: "Reports");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Reports");

            migrationBuilder.AddColumn<string>(
                name: "SenderId",
                table: "Reports",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ToUserId",
                table: "Reports",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reports_SenderId",
                table: "Reports",
                column: "SenderId");

            migrationBuilder.CreateIndex(
                name: "IX_Reports_ToUserId",
                table: "Reports",
                column: "ToUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reports_IdentityUser_SenderId",
                table: "Reports",
                column: "SenderId",
                principalTable: "IdentityUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reports_IdentityUser_ToUserId",
                table: "Reports",
                column: "ToUserId",
                principalTable: "IdentityUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
