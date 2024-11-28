using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorAppClientServer.Server.Migrations
{
	/// <inheritdoc />
	public partial class AddedAktuelPrisAndTotalPrisToYdelseTilOrdrecs : Migration
	{
		/// <inheritdoc />
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.RenameColumn(
				name: "YdelseMængdeId",
				table: "YdelseMængder",
				newName: "YdelseTilOrdreId");

			migrationBuilder.AddColumn<double>(
				name: "AktuelPris",
				table: "YdelseMængder",
				type: "float",
				nullable: false,
				defaultValue: 0.0);

			migrationBuilder.AddColumn<double>(
				name: "TotalPris",
				table: "YdelseMængder",
				type: "float",
				nullable: false,
				defaultValue: 0.0);
		}

		/// <inheritdoc />
		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DropColumn(
				name: "AktuelPris",
				table: "YdelseMængder");

			migrationBuilder.DropColumn(
				name: "TotalPris",
				table: "YdelseMængder");

			migrationBuilder.RenameColumn(
				name: "YdelseTilOrdreId",
				table: "YdelseMængder",
				newName: "YdelseMængdeId");
		}
	}
}
