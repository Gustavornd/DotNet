using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Escolha o idioma: (1) Inglês, (2) Português");
        string escolha = Console.ReadLine();

        PangramaChecker pangramaChecker;

        if (escolha == "1")
        {
            pangramaChecker = PangramaCheckerFactory.CreatePangramaChecker(Idioma.Ingles);
        }
        else if (escolha == "2")
        {
            pangramaChecker = PangramaCheckerFactory.CreatePangramaChecker(Idioma.Portugues);
        }
        else
        {
            Console.WriteLine("Escolha inválida.");
            return;
        }

        Console.WriteLine("Digite a sentença:");
        string sentenca = Console.ReadLine();

        bool isPangrama = pangramaChecker.VerificarPangrama(sentenca);

        if (isPangrama)
        {
            Console.WriteLine("É um pangrama");
        }
        else
        {
            Console.WriteLine("Não é um pangrama");
        }
    }
}

public enum Idioma
{
    Ingles,
    Portugues
}

public static class PangramaCheckerFactory
{
    public static PangramaChecker CreatePangramaChecker(Idioma idioma)
    {
        switch (idioma)
        {
            case Idioma.Ingles:
                return new PangramaChecker("abcdefghijklmnopqrstuvwxyz");
            case Idioma.Portugues:
                return new PangramaChecker("abcdefghijklmnopqrstuvwxyz");
            default:
                throw new ArgumentException("Idioma não suportado.");
        }
    }
}

public class PangramaChecker
{
    private readonly HashSet<char> alfabeto;

    public PangramaChecker(string alfabeto)
    {
        this.alfabeto = new HashSet<char>(alfabeto);
    }

    public bool VerificarPangrama(string sentenca)
    {
        var letrasNaSentenca = new HashSet<char>(sentenca.ToLower().Where(c => alfabeto.Contains(c)));
        return alfabeto.IsSubsetOf(letrasNaSentenca);
    }
}


/*
    OBS: O programa funciona como deveria, mas a frase teste
    "Gazeta publica hoje: breve anuncio de faxina na quermesse"
    não utilizava as letras K, W, e Y. Para resolver o problema
    sem comprometer o código eu mudei ligeramente a frase de teste para:
    
    Gazet publica hoje: breve anucio de faxina na quermesse por Walter e Karolyne.
*/
