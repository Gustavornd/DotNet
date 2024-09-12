using Microsoft.EntityFrameworkCore;

namespace WizardIngredients.Data;

public class IngredienteService{
    #region Métodos privados
    private IngredienteDbContext dbContext;
    #endregion

    #region Constructor
    public IngredienteService(IngredienteDbContext dbContext){
        this.dbContext = dbContext;
    }
    #endregion

    #region Metodos Publicos
    public async Task<List<Ingrediente>> RetornaIngredienteAsync(){
        return await dbContext.Ingrediente.ToListAsync();
    }

    public async Task<Ingrediente> AddIngredienteAsync(Ingrediente ingrediente){
        try{
            dbContext.Ingrediente.Add(ingrediente);
            await dbContext.SaveChangesAsync();
        }
        catch(Exception ex){
            throw;
        }
        return ingrediente;
    }

    public async Task<Ingrediente> UpdateIngredienteAsync(Ingrediente ingrediente){
        try{
            var ingredienteExist = dbContext.Ingrediente.FirstOrDefault(i => i.Id == ingrediente.Id);
            if(ingredienteExist != null){
                dbContext.Update(ingrediente);
                await dbContext.SaveChangesAsync();
            }
        }
        catch (Exception ex){
            throw;
        }
        return ingrediente;
    }

    public async Task DeleteIngredientesAsync(Ingrediente ingrediente){
        try {
            dbContext.Ingrediente.Remove(ingrediente);
            await dbContext.SaveChangesAsync();  
        }
        catch {
            throw;
        }
    }
    #endregion

}