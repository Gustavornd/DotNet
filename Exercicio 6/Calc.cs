using System.Collections.Generic;
using System.Linq;

public class Calc{

    //Variáveis
    private List<int> dados;

    //Construtor padrão
    public Calc(){
        dados = new List<int>();
    }

    //Get e Set
    public List<int> Dados{
        get {return dados;}
        set {dados = value;}
    }

    public void InserirNumero(int numero){
        dados.Add(numero);
    }

    public double CalcularMedia(){
        if(dados.Count == 0 ){
            return 0;}

        return dados.Average();
    }

    public double DesvioPadrão(){
        if (dados.Count == 0)
            return 0;

        double media = CalcularMedia();
        double somaQuadrados = dados.Sum(numero => Math.Pow(numero - media, 2));
        double desvioPadrao = Math.Sqrt(somaQuadrados / dados.Count);
        return desvioPadrao;
    }

    public override string ToString()
    {
        return "Media: " + CalcularMedia()
                + "\nDesvio Padrao: " + DesvioPadrão();
    }

}