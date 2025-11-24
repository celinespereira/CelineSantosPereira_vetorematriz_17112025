using System;

class Program
{
    static void Main()
    {
        char[] letras = new char[10];

        Console.WriteLine("Digite 10 letras para formar uma palavra:");

        for (int i = 0; i < letras.Length; i++)
        {
            Console.Write($"Letra {i + 1}: ");
            letras[i] = Console.ReadKey().KeyChar;
            Console.WriteLine();
        }

        string palavra = new string(letras);

        Console.WriteLine("\nPalavra em uma linha");
        Console.WriteLine(palavra);

        Console.WriteLine("\nPalavra em várias linhas");
        for (int i = 0; i < letras.Length; i++)
        {
            Console.WriteLine(letras[i]);
        }

        Console.WriteLine("\nFim!");
    }
}
