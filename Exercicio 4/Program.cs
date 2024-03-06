// 1-  Escrever par ou ímpar na tela, a partir de uma variável:
// a) Com Switch
Console.WriteLine("Insira um Numero: ");
int numero = Convert.ToInt32(Console.ReadLine() ?? "0");
int resto = numero % 2;

switch(resto){
        case 0: Console.WriteLine("Par"); break;
        default: Console.WriteLine("Impar"); break;
}


// b) Com if / else
if((numero % 2) == 0)
        Console.WriteLine("Par");

else 
        Console.WriteLine("Impar");


//c) Sem estrutura de controle:
string[] resultado = {"Par", "Impar"};
Console.WriteLine(resultado[numero % 2]);

//d) 
Console.WriteLine((resto == 0) ? "Par" : "Impar" );


// 2- Escreva um programa que use switch para encontrar 
//o valor máximo entre dois números

Console.WriteLine("Insira um numero A: ");
int a = Convert.ToInt32(Console.ReadLine() ?? "0");

Console.WriteLine("Insira um numero B: ");
int b = Convert.ToInt32(Console.ReadLine() ?? "0");

switch((a,b)){
        case (> 0, > 0) when a == b: 
                Console.WriteLine("São iguais.");
                break;
        case (> 0, > 0) when a < b:
                Console.WriteLine("B é maior.");
                break;
        default: 
                Console.WriteLine("A é maior.");
                break;
}