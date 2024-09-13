using Microsoft.EntityFrameworkCore;

namespace WizardIngredients.Data;

public class IngredienteDbContext : DbContext{

    #region Constructor 
    public IngredienteDbContext(DbContextOptions<IngredienteDbContext> 
    options) : base(options){

    }
    #endregion

    #region Propriedades
    public DbSet<Ingrediente> Ingrediente { get; set; }
    #endregion

    #region Método sobrecarregados
    protected override void OnModelCreating(ModelBuilder modelBuilder){

        modelBuilder.Entity<Ingrediente>().HasData(RetornarIngredidentes());
        base.OnModelCreating(modelBuilder);
    }
    #endregion

    #region Métodos Privados
    private List<Ingrediente> RetornarIngredidentes(){
        return new List<Ingrediente> {
            new Ingrediente {
                Id = 1001, 
                Nome = "Trigo", 
                Categoria = "Cereais",
                Alergicos = "Glútem",
                InfNutri = new List<string> {
                    "Calorias: 20 kcal",
                    "Carboidratos: 20 g",
                    "Gorduras Totais: 0 g"
                }
            },
            new Ingrediente {
                Id = 1002, 
                Nome = "Amendoim", 
                Categoria = "Cereais",
                Alergicos = "Castanhas",
                InfNutri = new List<string> {
                    "Calorias: 50 kcal",
                    "Carboidratos: 2 g",
                    "Gorduras Totais: 70 g"
                }
            },
            new Ingrediente {
                Id = 1003, 
                Nome = "Tomate", 
                Categoria = "Fruta",
                Alergicos = "Nenhum",
                InfNutri = new List<string> {
                    "Calorias: 89 kcal",
                    "Carboidratos: 1 g",
                    "Gorduras Totais: 0 g"
                }
            },
            new Ingrediente {
                Id = 1004, 
                Nome = "Alface", 
                Categoria = "Folhas",
                Alergicos = "Nenhum",
                InfNutri = new List<string> {
                    "Calorias: 20 kcal",
                    "Carboidratos: 0 g",
                    "Gorduras Totais: 0 g"
                }
            }
        };
    }
    #endregion
}