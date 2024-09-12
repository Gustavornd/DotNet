namespace WizardIngredients.Data;

public class InfNutri{
    public string? Nutriente { get; set; }
    public string? Quantidade { get; set; }

    public InfNutri(string? Nutriente, string? Quantidade){
        this.Nutriente = Nutriente;
        this.Quantidade = Quantidade;
    }

}