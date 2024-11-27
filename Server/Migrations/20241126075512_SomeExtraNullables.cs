using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorAppClientServer.Server.Migrations
{
	/// <inheritdoc />
	public partial class SomeExtraNullables : Migration
	{
		/// <inheritdoc />
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.AlterColumn<double>(
				name: "Timer",
				table: "Ydelser",
				type: "float",
				nullable: true,
				oldClrType: typeof(double),
				oldType: "float");
		}

		/// <inheritdoc />
		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.AlterColumn<double>(
				name: "Timer",
				table: "Ydelser",
				type: "float",
				nullable: false,
				defaultValue: 0.0,
				oldClrType: typeof(double),
				oldType: "float",
				oldNullable: true);
		}
	}
}