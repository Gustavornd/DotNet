using Microsoft.EntityFrameworkCore;

namespace hotsite.Data;
public class ProdutoServices
{
    #region Métodos privados
    private ProdutoDbContext dbContext;
    #endregion

    #region Construtor
    public ProdutoServices(ProdutoDbContext dbContext)
    {
        this.dbContext = dbContext;
    }
    #endregion

    #region Metodos Publicos 
    public async Task<List<Produto>> RetornaProdutoAsync()
    {
        return await dbContext.Produto.ToListAsync();
    }

    public async Task<Produto> AddProductAsync(Produto prod)
    {
        try
        {
            dbContext.Produto.Add(prod);
            await dbContext.SaveChangesAsync();
        }
        catch (Exception)
        {
            throw;
        }
        return prod;
    }

    public async Task<Produto> UpdateProductAsync(Produto prod)
    {
        try
        {
            var productExist = dbContext.Produto.FirstOrDefault(p => p.Id == prod.Id);
            if (productExist != null)
            {
                dbContext.Update(prod);
                await dbContext.SaveChangesAsync();
            }
        }
        catch (Exception)
        {
            throw;
        }
        return prod;
    }

    public async Task DeleteProductAsync(Produto produto)
    {
        try
        {
            dbContext.Produto.Remove(produto);
            await dbContext.SaveChangesAsync();
        }
        catch (Exception)
        {
            throw;
        }
    }
    #endregion
}