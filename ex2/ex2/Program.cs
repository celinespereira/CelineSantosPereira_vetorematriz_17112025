using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = new string[10];
            int i;

            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("{0}º nome:{1} ", i + 1, nomes[i]);
            }

            Console.ReadKey();
        }
    }
}