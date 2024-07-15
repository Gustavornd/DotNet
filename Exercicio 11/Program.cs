using System;
using System.Collections.Generic;

public interface IOrdenacao
{
    void Sort(List<string> lista);
}

public class QuickSort : IOrdenacao
{
    public void Sort(List<string> lista)
    {
        QuickSortRec(lista, 0, lista.Count - 1);
    }

    private void QuickSortRec(List<string> lista, int left, int right)
    {
        if (left < right)
        {
            int pivotIndex = Partition(lista, left, right);
            QuickSortRec(lista, left, pivotIndex - 1);
            QuickSortRec(lista, pivotIndex + 1, right);
        }
    }

    private int Partition(List<string> lista, int left, int right)
    {
        string pivot = lista[right];
        int i = left - 1;

        for (int j = left; j < right; j++)
        {
            if (string.Compare(lista[j], pivot) <= 0)
            {
                i++;
                (lista[i], lista[j]) = (lista[j], lista[i]);
            }
        }

        (lista[i + 1], lista[right]) = (lista[right], lista[i + 1]);
        return i + 1;
    }
}

public class MergeSort : IOrdenacao
{
    public void Sort(List<string> lista)
    {
        if (lista.Count <= 1)
            return;

        List<string> left = new List<string>();
        List<string> right = new List<string>();

        int mid = lista.Count / 2;
        for (int i = 0; i < mid; i++)
            left.Add(lista[i]);
        for (int i = mid; i < lista.Count; i++)
            right.Add(lista[i]);

        Sort(left);
        Sort(right);
        Merge(lista, left, right);
    }

    private void Merge(List<string> lista, List<string> left, List<string> right)
    {
        int i = 0, j = 0, k = 0;
        while (i < left.Count && j < right.Count)
        {
            if (string.Compare(left[i], right[j]) <= 0)
                lista[k++] = left[i++];
            else
                lista[k++] = right[j++];
        }

        while (i < left.Count)
            lista[k++] = left[i++];

        while (j < right.Count)
            lista[k++] = right[j++];
    }
}

public class ListaOrdenada
{
    private List<string> lista;
    private IOrdenacao estrategia;

    public ListaOrdenada()
    {
        lista = new List<string>();
    }

    public void Add(string nome)
    {
        lista.Add(nome);
    }

    public void SetEstrategia(IOrdenacao estrategia)
    {
        this.estrategia = estrategia;
    }

    public void Sort()
    {
        if (estrategia == null)
        {
            throw new InvalidOperationException("Estratégia de ordenação não definida.");
        }

        estrategia.Sort(lista);

        Console.WriteLine("Lista ordenada:");
        foreach (var nome in lista)
        {
            Console.WriteLine(nome);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        ListaOrdenada estudantes = new ListaOrdenada();
        estudantes.Add("Jose");
        estudantes.Add("Ana");
        estudantes.Add("Pedro");
        estudantes.Add("Mariana");

        estudantes.SetEstrategia(new QuickSort());
        estudantes.Sort();

        estudantes.SetEstrategia(new MergeSort());
        estudantes.Sort();
    }
}
