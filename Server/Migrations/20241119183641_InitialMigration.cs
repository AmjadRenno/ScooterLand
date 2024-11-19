using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorAppClientServer.Server.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KontorDamer",
                columns: table => new
                {
                    KontorDameId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KontorDamer", x => x.KontorDameId);
                });

            migrationBuilder.CreateTable(
                name: "Mekanikers",
                columns: table => new
                {
                    MekanikerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Navn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mekanikers", x => x.MekanikerId);
                });

            migrationBuilder.CreateTable(
                name: "Værkførers",
                columns: table => new
                {
                    VærkførerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Værkførers", x => x.VærkførerId);
                });

            migrationBuilder.CreateTable(
                name: "Mærker",
                columns: table => new
                {
                    MærkeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Navn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MekanikerId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mærker", x => x.MærkeId);
                    table.ForeignKey(
                        name: "FK_Mærker_Mekanikers_MekanikerId",
                        column: x => x.MekanikerId,
                        principalTable: "Mekanikers",
                        principalColumn: "MekanikerId");
                });

            migrationBuilder.CreateTable(
                name: "Kunder",
                columns: table => new
                {
                    KundeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Navn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adresse = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TelefonNummer = table.Column<int>(type: "int", nullable: false),
                    MekanikerId = table.Column<int>(type: "int", nullable: true),
                    MærkeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kunder", x => x.KundeId);
                    table.ForeignKey(
                        name: "FK_Kunder_Mekanikers_MekanikerId",
                        column: x => x.MekanikerId,
                        principalTable: "Mekanikers",
                        principalColumn: "MekanikerId");
                    table.ForeignKey(
                        name: "FK_Kunder_Mærker_MærkeId",
                        column: x => x.MærkeId,
                        principalTable: "Mærker",
                        principalColumn: "MærkeId");
                });

            migrationBuilder.CreateTable(
                name: "Ordrer",
                columns: table => new
                {
                    OrdreId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrdreDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    YdelseListeId = table.Column<int>(type: "int", nullable: true),
                    KundeId = table.Column<int>(type: "int", nullable: true),
                    MekanikerId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ordrer", x => x.OrdreId);
                    table.ForeignKey(
                        name: "FK_Ordrer_Kunder_KundeId",
                        column: x => x.KundeId,
                        principalTable: "Kunder",
                        principalColumn: "KundeId");
                    table.ForeignKey(
                        name: "FK_Ordrer_Mekanikers_MekanikerId",
                        column: x => x.MekanikerId,
                        principalTable: "Mekanikers",
                        principalColumn: "MekanikerId");
                });

            migrationBuilder.CreateTable(
                name: "Fakturaer",
                columns: table => new
                {
                    FakturaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrdreId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fakturaer", x => x.FakturaId);
                    table.ForeignKey(
                        name: "FK_Fakturaer_Ordrer_OrdreId",
                        column: x => x.OrdreId,
                        principalTable: "Ordrer",
                        principalColumn: "OrdreId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ydelser",
                columns: table => new
                {
                    YdelseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Navn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pris = table.Column<double>(type: "float", nullable: false),
                    Art = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Timer = table.Column<double>(type: "float", nullable: false),
                    OrdreId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ydelser", x => x.YdelseId);
                    table.ForeignKey(
                        name: "FK_Ydelser_Ordrer_OrdreId",
                        column: x => x.OrdreId,
                        principalTable: "Ordrer",
                        principalColumn: "OrdreId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Fakturaer_OrdreId",
                table: "Fakturaer",
                column: "OrdreId");

            migrationBuilder.CreateIndex(
                name: "IX_Kunder_MærkeId",
                table: "Kunder",
                column: "MærkeId");

            migrationBuilder.CreateIndex(
                name: "IX_Kunder_MekanikerId",
                table: "Kunder",
                column: "MekanikerId");

            migrationBuilder.CreateIndex(
                name: "IX_Mærker_MekanikerId",
                table: "Mærker",
                column: "MekanikerId");

            migrationBuilder.CreateIndex(
                name: "IX_Ordrer_KundeId",
                table: "Ordrer",
                column: "KundeId");

            migrationBuilder.CreateIndex(
                name: "IX_Ordrer_MekanikerId",
                table: "Ordrer",
                column: "MekanikerId");

            migrationBuilder.CreateIndex(
                name: "IX_Ydelser_OrdreId",
                table: "Ydelser",
                column: "OrdreId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Fakturaer");

            migrationBuilder.DropTable(
                name: "KontorDamer");

            migrationBuilder.DropTable(
                name: "Værkførers");

            migrationBuilder.DropTable(
                name: "Ydelser");

            migrationBuilder.DropTable(
                name: "Ordrer");

            migrationBuilder.DropTable(
                name: "Kunder");

            migrationBuilder.DropTable(
                name: "Mærker");

            migrationBuilder.DropTable(
                name: "Mekanikers");
        }
    }
}
