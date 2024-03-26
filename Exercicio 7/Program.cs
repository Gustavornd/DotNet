using System;

public class Calculator
{
    public static string Calcular(int valor1, int valor2, string operador)
    {
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
        try
        {
            Console.WriteLine(Calculator.Calcular(16, 51, "+"));
            Console.WriteLine(Calculator.Calcular(16, 51, "*"));
            Console.WriteLine(Calculator.Calcular(16, 0, "/"));
            Console.WriteLine(Calculator.Calcular(16, 51, "-")); // Gera uma exceção de argumento fora do intervalo
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }
    }
}

