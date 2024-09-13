using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WizardIngredients.Migrations
{
    /// <inheritdoc />
    public partial class MigrationInicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ingrediente",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: true),
                    Categoria = table.Column<string>(type: "TEXT", nullable: true),
                    Alergicos = table.Column<string>(type: "TEXT", nullable: true),
                    InfNutri = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingrediente", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Ingrediente",
                columns: new[] { "Id", "Alergicos", "Categoria", "InfNutri", "Nome" },
                values: new object[,]
                {
                    { 1001, "Glútem", "Cereais", "[\"Calorias: 20 kcal\",\"Carboidratos: 20 g\",\"Gorduras Totais: 0 g\"]", "Trigo" },
                    { 1002, "Castanhas", "Cereais", "[\"Calorias: 50 kcal\",\"Carboidratos: 2 g\",\"Gorduras Totais: 70 g\"]", "Amendoim" },
                    { 1003, "Nenhum", "Fruta", "[\"Calorias: 89 kcal\",\"Carboidratos: 1 g\",\"Gorduras Totais: 0 g\"]", "Tomate" },
                    { 1004, "Nenhum", "Folhas", "[\"Calorias: 20 kcal\",\"Carboidratos: 0 g\",\"Gorduras Totais: 0 g\"]", "Alface" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ingrediente");
        }
    }
}
