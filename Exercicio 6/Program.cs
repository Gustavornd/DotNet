// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;
using System.Linq;
using System;



class Program{
    static void Main(string[] args){

        Calc calculadora = new Calc();

        do{
            Console.WriteLine("1 - Adicionar número");
            Console.WriteLine("2 - Verificar média e desvio padrão");
            Console.WriteLine("3 - Finalizar");
            Console.Write("Escolha uma opção: ");
            int opcao = int.Parse(Console.ReadLine() ?? "0");

            switch (opcao)
            {
                case 1:
                    Console.Write("Digite um número: ");
                    int numero = int.Parse(Console.ReadLine() ?? "0");
                    calculadora.InserirNumero(numero);
                    break;
                case 2:
                    Console.WriteLine(calculadora.ToString());
                    break;
                case 3:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }

        }
        while(true);

    }
}
