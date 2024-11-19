using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorAppClientServer.Server.Migrations
{
    /// <inheritdoc />
    public partial class try1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Fakturaer_Ordrer_OrdreId",
                table: "Fakturaer");

            migrationBuilder.DropForeignKey(
                name: "FK_Kunder_Mekanikers_MekanikerId",
                table: "Kunder");

            migrationBuilder.DropForeignKey(
                name: "FK_Kunder_Mærker_MærkeId",
                table: "Kunder");

            migrationBuilder.DropForeignKey(
                name: "FK_Ydelser_YdelseListe_YdelseListeId",
                table: "Ydelser");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ydelser",
                table: "Ydelser");

            migrationBuilder.RenameTable(
                name: "Ydelser",
                newName: "Ydelse");

            migrationBuilder.RenameIndex(
                name: "IX_Ydelser_YdelseListeId",
                table: "Ydelse",
                newName: "IX_Ydelse_YdelseListeId");

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

            migrationBuilder.AlterColumn<int>(
                name: "OrdreId",
                table: "Fakturaer",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "YdelseListeId",
                table: "Ydelse",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "YdelseListId",
                table: "Ydelse",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ydelse",
                table: "Ydelse",
                column: "YdelseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Fakturaer_Ordrer_OrdreId",
                table: "Fakturaer",
                column: "OrdreId",
                principalTable: "Ordrer",
                principalColumn: "OrdreId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Ydelse_YdelseListe_YdelseListeId",
                table: "Ydelse",
                column: "YdelseListeId",
                principalTable: "YdelseListe",
                principalColumn: "YdelseListeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Fakturaer_Ordrer_OrdreId",
                table: "Fakturaer");

            migrationBuilder.DropForeignKey(
                name: "FK_Kunder_Mekanikers_MekanikerId",
                table: "Kunder");

            migrationBuilder.DropForeignKey(
                name: "FK_Kunder_Mærker_MærkeId",
                table: "Kunder");

            migrationBuilder.DropForeignKey(
                name: "FK_Ydelse_YdelseListe_YdelseListeId",
                table: "Ydelse");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ydelse",
                table: "Ydelse");

            migrationBuilder.RenameTable(
                name: "Ydelse",
                newName: "Ydelser");

            migrationBuilder.RenameIndex(
                name: "IX_Ydelse_YdelseListeId",
                table: "Ydelser",
                newName: "IX_Ydelser_YdelseListeId");

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

            migrationBuilder.AlterColumn<int>(
                name: "OrdreId",
                table: "Fakturaer",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "YdelseListeId",
                table: "Ydelser",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "YdelseListId",
                table: "Ydelser",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ydelser",
                table: "Ydelser",
                column: "YdelseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Fakturaer_Ordrer_OrdreId",
                table: "Fakturaer",
                column: "OrdreId",
                principalTable: "Ordrer",
                principalColumn: "OrdreId",
                onDelete: ReferentialAction.Cascade);

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
