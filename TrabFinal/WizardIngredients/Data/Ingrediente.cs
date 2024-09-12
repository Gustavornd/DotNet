namespace WizardIngredients.Data;

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

public class Ingrediente{
    public int Id { get; set;}
    public string? Nome { get; set;}

    public string? Categoria{ get; set;}
    public string? Alergicos { get; set;}

    [NotMapped]
    public List<InfNutri>? infNutri { get; set;}
    
};