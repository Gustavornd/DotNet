using System;

public class Calculator
{
    public static string Calcular(int? valor1, int? valor2, string? operador)
    {
        if (valor1 == null)
            throw new ArgumentNullException(nameof(valor1), "O valor não pode ser nulo.");
        
        if (valor2 == null)
            throw new ArgumentNullExecpion(nameof(valor2), "O valor não pode ser nulo.")

        if (operador == null)
            throw new ArgumentNullException(nameof(operador), "O operador não pode ser nulo.");
        
        if (operador != "+" && operador != "*" && operador != "/")
            throw new ArgumentOutOfRangeException(nameof(operador), "Operador inválido.");

        switch (operador)
        {
            case "+":
                return $"{valor1} + {valor2} = {valor1 + valor2}";
            case "*":
                return $"{valor1} * {valor2} = {valor1 * valor2}";
            case "/":
                if (valor2 == 0)
                    throw new DivideByZeroException("Divisão por zero não é permitida.");
                return $"{valor1} / {valor2} = {valor1 / valor2}";
            default:
                throw new ArgumentException("Operador inválido.");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        try{
            Console.WriteLine(Calculator.Calcular(null, 0,"+"));
        }
        catch (Exception ex){
            Console.WriteLine($"Erro: {ex.Message}");
        }

        

        try{
            Console.WriteLine(Calculator.Calcular(7, 45, null));
        }
        catch (Exception ex){
            Console.WriteLine($"Erro: {ex.Message}");
        }


        try{
            Console.WriteLine(Calculator.Calcular(7, 45, "+"));
        }
        catch (Exception ex){
            Console.WriteLine($"Erro: {ex.Message}");
        }


        try{
            Console.WriteLine(Calculator.Calcular(9, 8, "*"));
        }
        catch (Exception ex){
            Console.WriteLine($"Erro: {ex.Message}");
        }


        try{
            Console.WriteLine(Calculator.Calcular(16, 0, "/")); // Gera uma exeção de divisão por 0
        }
        catch (Exception ex){
            Console.WriteLine($"Erro: {ex.Message}");
        }


        try{
            Console.WriteLine(Calculator.Calcular(16, 51, "-")); // Gera uma exceção de argumento fora do intervalo
        }
        catch (Exception ex){
            Console.WriteLine($"Erro: {ex.Message}");
        }
    }
}

