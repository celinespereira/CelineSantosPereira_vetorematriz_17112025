using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            double sal_minimo = 678.00;
            double[] salarios = new double[10];

            for (i = 0; i < salarios.Length; i++)
                salarios[i] = (i + 1) * sal_minimo;

            for (i = 0; i < salarios.Length; i++)
                Console.WriteLine("\n{0} Salario(s) Minimo(s) = {1}", (i + 1), salarios[i].ToString("#00.00"));

            Console.ReadKey();
        }
    }
}