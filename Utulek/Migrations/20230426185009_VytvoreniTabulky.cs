using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Utulek.Migrations
{
    /// <inheritdoc />
    public partial class VytvoreniTabulky : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Jmeno = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pohlavi = table.Column<int>(type: "int", nullable: false),
                    Plemeno = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Vek = table.Column<int>(type: "int", nullable: false),
                    Hmotnost = table.Column<double>(type: "float", nullable: false),
                    Foto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Volny = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pes", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pes");
        }
    }
}
