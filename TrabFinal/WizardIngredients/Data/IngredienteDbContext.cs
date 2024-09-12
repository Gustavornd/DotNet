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
                new Categoria {Nome = "Cereais"},
                Alergicos = "Glútem",
                new List<InfNutri> {
                    new InfNutri {Nome = "Calorias", Quantidade="20 kcal"},
                    new InfNutri {Nome = "Carboidratos", Quantidade="20 g"},
                    new InfNutri {Nome = "Gorduras Totais", Quantidade="0 g"}
                    }
            }
            new Ingrediente {
                Id = 1002, 
                Nome = "Amendoim", 
                new Categoria {Nome = "Cereais"},
                Alergicos = "Castanhas",
                new List<InfNutri> {
                    new InfNutri {Nome = "Calorias", Quantidade="50 kcal"},
                    new InfNutri {Nome = "Carboidratos", Quantidade="2 g"},
                    new InfNutri {Nome = "Gorduras Totais", Quantidade="70 g"}
                    }
            }
            new Ingrediente {
                Id = 1003, 
                Nome = "Tomate", 
                new Categoria {Nome = "Fruta"},
                Alergicos = "Nenhum",
                new List<InfNutri> {
                    new InfNutri {Nome = "Calorias", Quantidade="50 kcal"},
                    new InfNutri {Nome = "Carboidratos", Quantidade="2 g"},
                    new InfNutri {Nome = "Gorduras Totais", Quantidade="70 g"}
                    }
            }
            new Ingrediente {
                Id = 1004, 
                Nome = "Amendoim", 
                new Categoria {Nome = "Cereais"},
                Alergicos = "Castanhas",
                new List<InfNutri> {
                    new InfNutri {Nome = "Calorias", Quantidade="50 kcal"},
                    new InfNutri {Nome = "Carboidratos", Quantidade="2 g"},
                    new InfNutri {Nome = "Gorduras Totais", Quantidade="70 g"}
                    }
            }
        }
    }
    #endregion
}