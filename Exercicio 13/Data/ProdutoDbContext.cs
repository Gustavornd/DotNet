// <sumary>
// Uma classe que herda "DbContext" para interagir e realizar
// operações de banco de dados.
// A classe também substitui o método OnModelCreating() para que o banco
// de dados possa ter alguns dados iniciais (seed data) para fins de teste.
// </sumary>


using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;  // Para List<>
using System.Threading.Tasks;      // Para Task<>


namespace Exercicio_13.Data;

public class ProdutoDbContext : DbContext{
    #region Constructor
    public ProdutoDbContext(DbContextOptions<ProdutoDbContext> options): base (options){

    }
    #endregion

    #region Propriedades
    public DbSet<Produto> Produto {get; set;}
    #endregion

    #region Metodos Sobrecarregados
    protected override void OnModelCreating(ModelBuilder modelBuilder){
        modelBuilder.Entity<Produto>().HasData(RetornarProdutos());
        base.OnModelCreating(modelBuilder);
    }
    #endregion

    #region Métodos privados
    private List<Produto> RetornarProdutos(){
        return new List<Produto>{
            new Produto {Id = 1001, Nome = "Laptop", Preço = 2000.02, Quant = 10, Descr = "Excelente notebook"},
            new Produto {Id = 1002, Nome = "Microsoft Office", Preço = 400.99, Quant = 50, Descr ="Um MS Office"},
            new Produto {Id = 1003, Nome = "Mouse", Preço = 12.02, Quant = 20, Descr ="Um mouse que funciona"},
            new Produto {Id = 1004, Nome = "HD USB", Preço = 5.00, Quant = 200, Descr ="Armazene incríveis 256GB de dados"}
        };
    }
    #endregion
}