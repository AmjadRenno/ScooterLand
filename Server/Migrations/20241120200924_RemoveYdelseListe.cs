using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorAppClientServer.Server.Migrations
{
    /// <inheritdoc />
    public partial class RemoveYdelseListe : Migration
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
                name: "FK_Ordrer_YdelseListe_YdelseListeId",
                table: "Ordrer");

            migrationBuilder.DropForeignKey(
                name: "FK_Ydelser_YdelseListe_YdelseListeId",
                table: "Ydelser");

            migrationBuilder.DropTable(
                name: "YdelseListe");

            migrationBuilder.DropIndex(
                name: "IX_Ydelser_YdelseListeId",
                table: "Ydelser");

            migrationBuilder.DropIndex(
                name: "IX_Ordrer_YdelseListeId",
                table: "Ordrer");

            migrationBuilder.DropColumn(
                name: "YdelseListeId",
                table: "Ydelser");

            migrationBuilder.AlterColumn<int>(
                name: "YdelseListId",
                table: "Ydelser",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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

            migrationBuilder.AlterColumn<int>(
                name: "YdelseListId",
                table: "Ydelser",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "YdelseListeId",
                table: "Ydelser",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.CreateTable(
                name: "YdelseListe",
                columns: table => new
                {
                    YdelseListeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YdelseListe", x => x.YdelseListeId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ydelser_YdelseListeId",
                table: "Ydelser",
                column: "YdelseListeId");

            migrationBuilder.CreateIndex(
                name: "IX_Ordrer_YdelseListeId",
                table: "Ordrer",
                column: "YdelseListeId");

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
                name: "FK_Ordrer_YdelseListe_YdelseListeId",
                table: "Ordrer",
                column: "YdelseListeId",
                principalTable: "YdelseListe",
                principalColumn: "YdelseListeId");

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
