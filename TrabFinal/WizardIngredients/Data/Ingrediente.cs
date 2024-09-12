namespace WizardIngredients.Data;

using System.Collections.Generic;
using System.Linq;
using WizardIngredients.Data;


public class Ingrediente{
    public int Id { get; set;}
    public string? Nome { get; set;}

    public Categoria? categoria{ get; set;}
    public string? Alergicos { get; set;}
    public List<InfNutri>? infNutri { get; set;}
    
};