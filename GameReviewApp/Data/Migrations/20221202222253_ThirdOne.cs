using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameReviewApp.Data.Migrations
{
    public partial class ThirdOne : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_DoneBoards_ToPlayBoardId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_ToPlayBoards_ToPlayBoardId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_ToPlayBoardId",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "ToPlayBoards",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "DoneBoards",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_ToPlayBoards_UserId",
                table: "ToPlayBoards",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DoneBoards_UserId",
                table: "DoneBoards",
                column: "UserId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_DoneBoards_AspNetUsers_UserId",
                table: "DoneBoards",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ToPlayBoards_AspNetUsers_UserId",
                table: "ToPlayBoards",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DoneBoards_AspNetUsers_UserId",
                table: "DoneBoards");

            migrationBuilder.DropForeignKey(
                name: "FK_ToPlayBoards_AspNetUsers_UserId",
                table: "ToPlayBoards");

            migrationBuilder.DropIndex(
                name: "IX_ToPlayBoards_UserId",
                table: "ToPlayBoards");

            migrationBuilder.DropIndex(
                name: "IX_DoneBoards_UserId",
                table: "DoneBoards");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "ToPlayBoards");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "DoneBoards");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_ToPlayBoardId",
                table: "AspNetUsers",
                column: "ToPlayBoardId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_DoneBoards_ToPlayBoardId",
                table: "AspNetUsers",
                column: "ToPlayBoardId",
                principalTable: "DoneBoards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_ToPlayBoards_ToPlayBoardId",
                table: "AspNetUsers",
                column: "ToPlayBoardId",
                principalTable: "ToPlayBoards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
