using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BethanysPieShop.Migrations
{
    public partial class ExoticBeberageAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ExoticBeberages",
                columns: table => new
                {
                    ExoticBeberageId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(nullable: true),
                    Step1 = table.Column<string>(nullable: true),
                    Step2 = table.Column<string>(nullable: true),
                    Step3 = table.Column<string>(nullable: true),
                    Step4 = table.Column<string>(nullable: true),
                    Step5 = table.Column<string>(nullable: true),
                    Ingrediente1 = table.Column<string>(nullable: true),
                    Ingrediente2 = table.Column<string>(nullable: true),
                    Ingrediente3 = table.Column<string>(nullable: true),
                    Ingrediente4 = table.Column<string>(nullable: true),
                    Ingrediente5 = table.Column<string>(nullable: true),
                    Costo = table.Column<double>(nullable: false),
                    PiezasPorPaquetes = table.Column<int>(nullable: false),
                    Paquetes = table.Column<int>(nullable: false),
                    Disponible = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExoticBeberages", x => x.ExoticBeberageId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExoticBeberages");
        }
    }
}
