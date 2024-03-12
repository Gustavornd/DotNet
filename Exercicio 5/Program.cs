double t_juros,n_parcelas,valor_financiamento,prestacao,cf=0, juros, total;
int i;
do{
Console.WriteLine("Digite a taxa de juros: ");
t_juros = double.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Digite o numero de parcelas: ");
n_parcelas = double.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Digite o valor do finaciamento: ");
valor_financiamento = double.Parse(Console.ReadLine() ?? "0");

cf = (t_juros/100)/(1-Math.Pow((1+(t_juros/100)),-n_parcelas));


prestacao = valor_financiamento * cf;
total = n_parcelas * prestacao;
juros = total - valor_financiamento;


prestacao = Math.Round(prestacao,2 , MidpointRounding.ToZero);
juros = Math.Round(juros,2,MidpointRounding.ToZero);
total = Math.Round(total,2,MidpointRounding.ToZero);

Console.WriteLine("Valor da parcela: " + prestacao.ToString("F"));
Console.WriteLine("O total desse financiamento de " + n_parcelas + " parcelas é de " 
                        + total.ToString("F") +" reais, sendo " 
                        + juros.ToString("F") + " de juros.");

Console.WriteLine("\nDigite 0 para continuar ou qualquer outro numero para sair: ");
i = int.Parse(Console.ReadLine() ?? "0");

}while ( i == 0);