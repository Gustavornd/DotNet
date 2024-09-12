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
                name: "InfNutri",
                columns: table => new
                {
                    Nutriente = table.Column<string>(type: "TEXT", nullable: true),
                    Quantidade = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Ingrediente",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: true),
                    Categoria = table.Column<string>(type: "TEXT", nullable: true),
                    Alergicos = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingrediente", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Ingrediente",
                columns: new[] { "Id", "Alergicos", "Categoria", "Nome" },
                values: new object[,]
                {
                    { 1001, "Glútem", "Cereais", "Trigo" },
                    { 1002, "Castanhas", "Cereais", "Amendoim" },
                    { 1003, "Nenhum", "Fruta", "Tomate" },
                    { 1004, "Nenhum", "Folhas", "Alface" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InfNutri");

            migrationBuilder.DropTable(
                name: "Ingrediente");
        }
    }
}
