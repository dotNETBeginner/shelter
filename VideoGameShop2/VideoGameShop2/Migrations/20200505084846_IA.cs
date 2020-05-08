using Microsoft.EntityFrameworkCore.Migrations;

namespace VideoGameShop2.Migrations
{
    public partial class IA : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Id_User",
                table: "UserBoughts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_UserBoughts_Id_User",
                table: "UserBoughts",
                column: "Id_User");

            migrationBuilder.AddForeignKey(
                name: "FK_UserBoughts_AspNetUsers_Id_User",
                table: "UserBoughts",
                column: "Id_User",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserBoughts_AspNetUsers_Id_User",
                table: "UserBoughts");

            migrationBuilder.DropIndex(
                name: "IX_UserBoughts_Id_User",
                table: "UserBoughts");

            migrationBuilder.DropColumn(
                name: "Id_User",
                table: "UserBoughts");
        }
    }
}
