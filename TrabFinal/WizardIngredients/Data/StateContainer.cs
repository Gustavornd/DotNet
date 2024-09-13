using WizardIngredients.Data;

public class StateContainer {
    public Ingrediente? ingrediente { get; set; }

    public void AtualizaValor(Ingrediente ingrediente){
        this.ingrediente = ingrediente;
    }
}