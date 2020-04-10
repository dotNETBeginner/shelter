using Microsoft.EntityFrameworkCore.Migrations;

namespace VideoGameShop2.Migrations
{
    public partial class newPrimaryKeyNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Developers_Publishers_Id_Publisher",
                table: "Developers");

            migrationBuilder.DropForeignKey(
                name: "FK_Games_Developers_Id_Dev",
                table: "Games");

            migrationBuilder.DropForeignKey(
                name: "FK_Games_Genres_Id_Genre",
                table: "Games");

            migrationBuilder.DropForeignKey(
                name: "FK_UserBoughts_Games_Id_Game",
                table: "UserBoughts");

            migrationBuilder.DropForeignKey(
                name: "FK_UserBoughts_Users_Id_User",
                table: "UserBoughts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserBoughts",
                table: "UserBoughts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Publishers",
                table: "Publishers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Genres",
                table: "Genres");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Games",
                table: "Games");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Developers",
                table: "Developers");

            migrationBuilder.DropColumn(
                name: "Id_User",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Id_Purchase",
                table: "UserBoughts");

            migrationBuilder.DropColumn(
                name: "Id_Publisher",
                table: "Publishers");

            migrationBuilder.DropColumn(
                name: "Id_Genre",
                table: "Genres");

            migrationBuilder.DropColumn(
                name: "Id_Game",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "Id_Dev",
                table: "Developers");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Users",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "UserBoughts",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Publishers",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Genres",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Games",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Developers",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserBoughts",
                table: "UserBoughts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Publishers",
                table: "Publishers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Genres",
                table: "Genres",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Games",
                table: "Games",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Developers",
                table: "Developers",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Developers_Publishers_Id_Publisher",
                table: "Developers",
                column: "Id_Publisher",
                principalTable: "Publishers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Games_Developers_Id_Dev",
                table: "Games",
                column: "Id_Dev",
                principalTable: "Developers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Games_Genres_Id_Genre",
                table: "Games",
                column: "Id_Genre",
                principalTable: "Genres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserBoughts_Games_Id_Game",
                table: "UserBoughts",
                column: "Id_Game",
                principalTable: "Games",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserBoughts_Users_Id_User",
                table: "UserBoughts",
                column: "Id_User",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Developers_Publishers_Id_Publisher",
                table: "Developers");

            migrationBuilder.DropForeignKey(
                name: "FK_Games_Developers_Id_Dev",
                table: "Games");

            migrationBuilder.DropForeignKey(
                name: "FK_Games_Genres_Id_Genre",
                table: "Games");

            migrationBuilder.DropForeignKey(
                name: "FK_UserBoughts_Games_Id_Game",
                table: "UserBoughts");

            migrationBuilder.DropForeignKey(
                name: "FK_UserBoughts_Users_Id_User",
                table: "UserBoughts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserBoughts",
                table: "UserBoughts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Publishers",
                table: "Publishers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Genres",
                table: "Genres");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Games",
                table: "Games");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Developers",
                table: "Developers");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "UserBoughts");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Publishers");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Genres");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Developers");

            migrationBuilder.AddColumn<int>(
                name: "Id_User",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id_Purchase",
                table: "UserBoughts",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id_Publisher",
                table: "Publishers",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id_Genre",
                table: "Genres",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id_Game",
                table: "Games",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id_Dev",
                table: "Developers",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id_User");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserBoughts",
                table: "UserBoughts",
                column: "Id_Purchase");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Publishers",
                table: "Publishers",
                column: "Id_Publisher");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Genres",
                table: "Genres",
                column: "Id_Genre");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Games",
                table: "Games",
                column: "Id_Game");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Developers",
                table: "Developers",
                column: "Id_Dev");

            migrationBuilder.AddForeignKey(
                name: "FK_Developers_Publishers_Id_Publisher",
                table: "Developers",
                column: "Id_Publisher",
                principalTable: "Publishers",
                principalColumn: "Id_Publisher",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Games_Developers_Id_Dev",
                table: "Games",
                column: "Id_Dev",
                principalTable: "Developers",
                principalColumn: "Id_Dev",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Games_Genres_Id_Genre",
                table: "Games",
                column: "Id_Genre",
                principalTable: "Genres",
                principalColumn: "Id_Genre",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserBoughts_Games_Id_Game",
                table: "UserBoughts",
                column: "Id_Game",
                principalTable: "Games",
                principalColumn: "Id_Game",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserBoughts_Users_Id_User",
                table: "UserBoughts",
                column: "Id_User",
                principalTable: "Users",
                principalColumn: "Id_User",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
