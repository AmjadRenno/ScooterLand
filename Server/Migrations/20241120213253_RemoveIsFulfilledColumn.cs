using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorAppClientServer.Server.Migrations
{
    /// <inheritdoc />
    public partial class RemoveIsFulfilledColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "YdelseListId",
                table: "Ydelser");

            migrationBuilder.DropColumn(
                name: "YdelseListeId",
                table: "Ordrer");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "YdelseListId",
                table: "Ydelser",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "YdelseListeId",
                table: "Ordrer",
                type: "int",
                nullable: true);
        }
    }
}
