using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorAppClientServer.Server.Migrations
{
    /// <inheritdoc />
    public partial class test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ordrer_Kunder_KundeId",
                table: "Ordrer");

            migrationBuilder.DropForeignKey(
                name: "FK_Ordrer_Mekanikers_MekanikerId",
                table: "Ordrer");

            migrationBuilder.DropForeignKey(
                name: "FK_Ordrer_YdelseListe_YdelseListeId",
                table: "Ordrer");

            migrationBuilder.RenameColumn(
                name: "OdreDate",
                table: "Ordrer",
                newName: "OrdreDate");

            migrationBuilder.AlterColumn<int>(
                name: "YdelseListeId",
                table: "Ordrer",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "MekanikerId",
                table: "Ordrer",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "KundeId",
                table: "Ordrer",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Navn",
                table: "Mekanikers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_Ordrer_Kunder_KundeId",
                table: "Ordrer",
                column: "KundeId",
                principalTable: "Kunder",
                principalColumn: "KundeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ordrer_Mekanikers_MekanikerId",
                table: "Ordrer",
                column: "MekanikerId",
                principalTable: "Mekanikers",
                principalColumn: "MekanikerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ordrer_YdelseListe_YdelseListeId",
                table: "Ordrer",
                column: "YdelseListeId",
                principalTable: "YdelseListe",
                principalColumn: "YdelseListeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ordrer_Kunder_KundeId",
                table: "Ordrer");

            migrationBuilder.DropForeignKey(
                name: "FK_Ordrer_Mekanikers_MekanikerId",
                table: "Ordrer");

            migrationBuilder.DropForeignKey(
                name: "FK_Ordrer_YdelseListe_YdelseListeId",
                table: "Ordrer");

            migrationBuilder.DropColumn(
                name: "Navn",
                table: "Mekanikers");

            migrationBuilder.RenameColumn(
                name: "OrdreDate",
                table: "Ordrer",
                newName: "OdreDate");

            migrationBuilder.AlterColumn<int>(
                name: "YdelseListeId",
                table: "Ordrer",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MekanikerId",
                table: "Ordrer",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "KundeId",
                table: "Ordrer",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Ordrer_Kunder_KundeId",
                table: "Ordrer",
                column: "KundeId",
                principalTable: "Kunder",
                principalColumn: "KundeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ordrer_Mekanikers_MekanikerId",
                table: "Ordrer",
                column: "MekanikerId",
                principalTable: "Mekanikers",
                principalColumn: "MekanikerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ordrer_YdelseListe_YdelseListeId",
                table: "Ordrer",
                column: "YdelseListeId",
                principalTable: "YdelseListe",
                principalColumn: "YdelseListeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
