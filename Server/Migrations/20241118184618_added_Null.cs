using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorAppClientServer.Server.Migrations
{
    /// <inheritdoc />
    public partial class added_Null : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kunder_Mekanikers_MekanikerId",
                table: "Kunder");

            migrationBuilder.DropForeignKey(
                name: "FK_Kunder_Mærker_MærkeId",
                table: "Kunder");

            migrationBuilder.AlterColumn<int>(
                name: "MærkeId",
                table: "Kunder",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "MekanikerId",
                table: "Kunder",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Kunder_Mekanikers_MekanikerId",
                table: "Kunder",
                column: "MekanikerId",
                principalTable: "Mekanikers",
                principalColumn: "MekanikerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Kunder_Mærker_MærkeId",
                table: "Kunder",
                column: "MærkeId",
                principalTable: "Mærker",
                principalColumn: "MærkeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kunder_Mekanikers_MekanikerId",
                table: "Kunder");

            migrationBuilder.DropForeignKey(
                name: "FK_Kunder_Mærker_MærkeId",
                table: "Kunder");

            migrationBuilder.AlterColumn<int>(
                name: "MærkeId",
                table: "Kunder",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MekanikerId",
                table: "Kunder",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Kunder_Mekanikers_MekanikerId",
                table: "Kunder",
                column: "MekanikerId",
                principalTable: "Mekanikers",
                principalColumn: "MekanikerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Kunder_Mærker_MærkeId",
                table: "Kunder",
                column: "MærkeId",
                principalTable: "Mærker",
                principalColumn: "MærkeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
