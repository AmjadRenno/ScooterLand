using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorAppClientServer.Server.Migrations
{
    /// <inheritdoc />
    public partial class Added_Ordre_Liste_To_Ydelsecs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ydelser_Ordrer_OrdreId",
                table: "Ydelser");

            migrationBuilder.DropIndex(
                name: "IX_Ydelser_OrdreId",
                table: "Ydelser");

            migrationBuilder.DropColumn(
                name: "OrdreId",
                table: "Ydelser");

            migrationBuilder.CreateTable(
                name: "OrdreYdelse",
                columns: table => new
                {
                    OrdreListeOrdreId = table.Column<int>(type: "int", nullable: false),
                    YdelseListeYdelseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdreYdelse", x => new { x.OrdreListeOrdreId, x.YdelseListeYdelseId });
                    table.ForeignKey(
                        name: "FK_OrdreYdelse_Ordrer_OrdreListeOrdreId",
                        column: x => x.OrdreListeOrdreId,
                        principalTable: "Ordrer",
                        principalColumn: "OrdreId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrdreYdelse_Ydelser_YdelseListeYdelseId",
                        column: x => x.YdelseListeYdelseId,
                        principalTable: "Ydelser",
                        principalColumn: "YdelseId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrdreYdelse_YdelseListeYdelseId",
                table: "OrdreYdelse",
                column: "YdelseListeYdelseId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrdreYdelse");

            migrationBuilder.AddColumn<int>(
                name: "OrdreId",
                table: "Ydelser",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ydelser_OrdreId",
                table: "Ydelser",
                column: "OrdreId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ydelser_Ordrer_OrdreId",
                table: "Ydelser",
                column: "OrdreId",
                principalTable: "Ordrer",
                principalColumn: "OrdreId");
        }
    }
}
