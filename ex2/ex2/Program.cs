using System;

class Program
{
    static void Main()
    {
        Console.Write("Quantas letras terá a palavra? ");
        int qt = int.Parse(Console.ReadLine());

        char[] letras = new char[qt];

        Console.WriteLine("\nDigite as letras da palavra:");

        for (int i = 0; i < qt; i++)
        {
            Console.Write($"Letra {i + 1}: ");
            letras[i] = Console.ReadKey().KeyChar;
            Console.WriteLine();
        }

        string palavra = new string(letras);

        Console.WriteLine("\nPalavra completa");
        Console.WriteLine(palavra);

        Console.WriteLine("\nLetras linha por linha");
        for (int i = 0; i < qt; i++)
        {
            Console.WriteLine(letras[i]);
        }

        Console.WriteLine("\nFinal");
    }
}