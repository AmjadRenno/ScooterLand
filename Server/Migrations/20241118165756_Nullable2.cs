using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorAppClientServer.Server.Migrations
{
    /// <inheritdoc />
    public partial class Nullable2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ydelser_YdelseListe_YdelseListeId",
                table: "Ydelser");

            migrationBuilder.AlterColumn<int>(
                name: "YdelseListeId",
                table: "Ydelser",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Ydelser_YdelseListe_YdelseListeId",
                table: "Ydelser",
                column: "YdelseListeId",
                principalTable: "YdelseListe",
                principalColumn: "YdelseListeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ydelser_YdelseListe_YdelseListeId",
                table: "Ydelser");

            migrationBuilder.AlterColumn<int>(
                name: "YdelseListeId",
                table: "Ydelser",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Ydelser_YdelseListe_YdelseListeId",
                table: "Ydelser",
                column: "YdelseListeId",
                principalTable: "YdelseListe",
                principalColumn: "YdelseListeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
