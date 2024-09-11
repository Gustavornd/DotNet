using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;  // Para List<>
using System.Threading.Tasks;      // Para Task<>
using System;
using System.Linq;




namespace Exercicio_13.Data;

public class ProdutoServices{
    #region Métodos privados
    private ProdutoDbContext dbContext;
    #endregion

    #region Constructor
    public ProdutoServices (ProdutoDbContext dbContext)
    {
        this.dbContext = dbContext;
    }
    #endregion

    #region Métodos Públicos

    //Retorna a Lista de produtos
    public async Task<List<Produto>> RetornaProdutoAsync(){
        return await dbContext.Produto.ToListAsync();
    }

    //Adiciona um produto para DbContext e o salva
    public async Task<Produto> AddProductAsync(Produto prod){
        try{
            dbContext.Produto.Add(prod);
            await dbContext.SaveChangesAsync();
        }
        catch(Exception){
            throw;
        }
        return prod;
    }

    // Atualiza um produto e salva as mudanças
    public async Task<Produto> UpdateProductAsync(Produto prod){
        try{
            var productExist = dbContext.Produto.FirstOrDefault(p => p.Id == prod.Id);
            if (productExist != null)
            {
                dbContext.Update(prod);
                await dbContext.SaveChangesAsync();
            }
        }
        catch(Exception){
            throw;
        }
        return prod;
    }


    // Remove um produto de DbContext e o salva
    public async Task DeleteProductAsync(Produto produto){
        try{
            dbContext.Produto.Remove(produto);
            await dbContext.SaveChangesAsync();
        }
        catch(Exception){
            throw;
        }
    }

    #endregion
}