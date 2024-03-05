int a  = int.Parse(Console.ReadLine() ?? "0");
int b = int.Parse(Console.ReadLine() ?? "0");

Func<int, int, int> soma = (x,y) => (x+y);
Func<int, int, int> subtracao = (x,y) => (x-y);
Func<int, int, int> divisao = (x,y) => (y.Equals(0) ? 0 : (x/y));
Func<int, int, int> multiplicacao = (x,y) => (x*y);
Func<int, int, int> resto = (x,y) => (y.Equals(0) ? 0 : (x%y));


Console.WriteLine("Soma: " + soma(a,b));
Console.WriteLine("Subtração: " + subtracao(a,b));
Console.WriteLine("Divisão: " + divisao(a,b) + " Resto: " + resto(a,b));
Console.WriteLine("Multiplicação: " + multiplicacao(a,b));

Func<int, int, List<int>> calculadora = (x,y) => {
        List<int> solucoes = new List<int>();
        solucoes.Add(x+y);
        solucoes.Add(x-y);
        solucoes.Add(y.Equals(0) ? 0 : (x/y));
        solucoes.Add(x*y);
        solucoes.Add(y.Equals(0) ? 0 : (x%y));
        return solucoes;
};

List<int> resultados = calculadora(a,b);

Console.WriteLine("Resultados no Vetor retornado: ");
foreach (int item in resultados)
{       
        Console.WriteLine(item);
}


/* Saida do Terminal

30
6
Soma: 36
Subtração: 24
Divisão: 5 Resto: 0
Multiplicação: 180
Resultados no Vetor retornado: 
36
24
5
180
0

*/

