using System;

class Program
{
    static void Main()
    {
        Console.Write("Quantas letras terá a palavra? ");
        int quantidade = int.Parse(Console.ReadLine());

        char[] letras = new char[quantidade];

        Console.WriteLine("\nDigite as letras da palavra:");
        for (int i = 0; i < quantidade; i++)
        {
            Console.Write($"Letra {i + 1}: ");
            letras[i] = Console.ReadKey().KeyChar;
            Console.WriteLine();
        }

        string palavra = new string(letras);

        Console.WriteLine("\n--- Tentativas de adivinhar uma letra ---");

        bool acertou = false;

        for (int tentativa = 1; tentativa <= 3; tentativa++)
        {
            Console.Write($"\nTentativa {tentativa}/3 - Digite uma letra: ");
            char chute = Console.ReadKey().KeyChar;
            Console.WriteLine();

            if (palavra.Contains(chute))
            {
                Console.WriteLine($"\n✔ A letra '{chute}' existe na palavra!");
                acertou = true;
                break;
            }
            else
            {
                Console.WriteLine($"✘ A letra '{chute}' NÃO existe na palavra.");
            }
        }

        if (!acertou)
        {
            Console.WriteLine("\nVocê não acertou nenhuma letra nas 3 tentativas.");
        }

        Console.WriteLine("\nPalavra completa");
        Console.WriteLine(palavra);

        Console.WriteLine("\nLetras linha por linha");
        for (int i = 0; i < quantidade; i++)
        {
            Console.WriteLine(letras[i]);
        }

        Console.WriteLine("\nFinal");
    }
}
