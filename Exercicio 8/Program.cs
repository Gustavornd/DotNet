using System;
using System.Collections.Generic;
using System.Linq;

class AnagramSolver
{
    private string baseWord;
    private List<string> candidateWords;

    public AnagramSolver(string baseWord, List<string> candidateWords)
    {
        this.baseWord = baseWord.ToLower();
        this.candidateWords = candidateWords.Select(w => w.ToLower()).ToList();
    }

    public void FindAnagrams()
    {
        try
        {
            if (string.IsNullOrWhiteSpace(baseWord))
            {
                throw new ArgumentException("Palavra base não pode ser vazia");
            }

            List<string> anagrams = new List<string>();
            foreach (string candidate in candidateWords)
            {
                if (IsAnagram(baseWord, candidate))
                {
                    anagrams.Add(candidate);
                }
            }

            if (anagrams.Count == 0)
            {
                Console.WriteLine("Nenhum anagrama");
            }
            else
            {
                Console.WriteLine("Anagramas:");
                foreach (string anagram in anagrams)
                {
                    Console.WriteLine(anagram);
                }
            }
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (Exception e)
        {
            Console.WriteLine("Ocorreu um erro: " + e.Message);
        }
    }

    private bool IsAnagram(string word1, string word2)
    {
        if (word1.Length != word2.Length || word1 == word2)
        {
            return false;
        }

        char[] charArray1 = word1.ToCharArray();
        char[] charArray2 = word2.ToCharArray();
        Array.Sort(charArray1);
        Array.Sort(charArray2);

        return Enumerable.SequenceEqual(charArray1, charArray2);
    }
}

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Digite a palavra base:");
            string baseWord = Console.ReadLine();

            Console.WriteLine("Digite a lista de palavras candidatas (separadas por espaço):");
            string[] candidateWordsArray = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            List<string> candidateWords = candidateWordsArray.ToList();

            AnagramSolver solver = new AnagramSolver(baseWord, candidateWords);
            solver.FindAnagrams();
        }
        catch (Exception e)
        {
            Console.WriteLine("Ocorreu um erro: " + e.Message);
        }
    }
}

