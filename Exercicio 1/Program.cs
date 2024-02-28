
//Questão 1:
        //Exemplo 1;

        int num1 = 5;
        int num2 = 5;
        bool result = Equals(num1, num2);
        Console.WriteLine("Resultado: " + result);

        //Exemplo 2:
        String str1 = "Gustavo";
        String str2 = "Gustavo";
        result = str1.Equals(str2);
        Console.WriteLine("Resultado: " + result);

        //Exemplo 3:
        int num3 = 4;
        int [] numbers = {1,2,3,4,5,6};
        result = numbers[3].Equals(num3);
        Console.WriteLine("Resultado: " + result);
        /* Saida:
                Resultado: True
                Resultado: True
                Resultado: True
        */


//Questão 2:

        int [] a = {1,2,3,4,5};
        int [] b = new int[a.Length];
        Array.Copy(a, b, a.Length);
        b[0] = 25;
        b[1] = 30;
        Console.WriteLine("a: " + a[0] + ", "+a[1]);
        Console.WriteLine("b: " + b[0] + ", "+b[1]);
        /* Saida:
                a: 1, 2
                b: 25, 30
        */


//Questão 3:
        //Declara a nova lista chamada "nomes" que armazena strings, sendo uma lista vazia de inicio;
        List<string> nomes = new List<string>(); 

        //O método AddRange adiciona elementos ao final da lista "nomes".
        nomes.AddRange(new [] {".net", "2023", "ifnmg"});

        //Imprime na tela o tipo do objeto que representa a lista "nomes".
        Console.WriteLine(nomes);
        /* Saida:
                System.Collections.Generic.List`1[System.String]
        */


//Questão 4:
        Console.WriteLine(string.Join(", ", nomes));
        /* Saida:
                .net, 2023, ifnmg
        */

