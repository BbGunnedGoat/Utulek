using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Utulek.Migrations
{
    /// <inheritdoc />
    public partial class MestoNalezu : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Hmotnost",
                table: "Pes",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AddColumn<string>(
                name: "MestoNalezu",
                table: "Pes",
                type: "nvarchar(max)",
                nullable: true);

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.DropColumn(
                name: "MestoNalezu",
                table: "Pes");

            migrationBuilder.AlterColumn<double>(
                name: "Hmotnost",
                table: "Pes",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");
        }
    }
}
