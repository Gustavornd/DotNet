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
        modelBuilder.Entity<Ingrediente>().Ignore(i => i.infNutri);
        modelBuilder.Entity<Ingrediente>().HasData(RetornarIngredidentes());
        modelBuilder.Entity<InfNutri>().HasNoKey();
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
                infNutri = new List<InfNutri> {
                        new InfNutri("Calorias", "20 kcal"),
                        new InfNutri("Carboidratos", "20 g"),
                        new InfNutri ("Gorduras Totais", "0 g")
                    }
            },
            new Ingrediente {
                Id = 1002, 
                Nome = "Amendoim", 
                Categoria = "Cereais",
                Alergicos = "Castanhas",
                infNutri = new List<InfNutri> {
                    new InfNutri("Calorias", "50 kcal"),
                    new InfNutri("Carboidratos", "2 g"),
                    new InfNutri("Gorduras Totais", "70 g")
                    }
            },
            new Ingrediente {
                Id = 1003, 
                Nome = "Tomate", 
                Categoria = "Fruta",
                Alergicos = "Nenhum",
                infNutri = new List<InfNutri> {
                    new InfNutri("Calorias", "89 kcal"),
                    new InfNutri("Carboidratos", "1 g"),
                    new InfNutri("Gorduras Totais", "0 g")
                    }
            },
            new Ingrediente {
                Id = 1004, 
                Nome = "Alface", 
                Categoria = "Folhas",
                Alergicos = "Nenhum",
                infNutri = new List<InfNutri> {
                    new InfNutri("Calorias", "20 kcal"),
                    new InfNutri("Carboidratos", "0 g"),
                    new InfNutri("Gorduras Totais", "0 g")
                    }
            }
        };
    }
    #endregion
}