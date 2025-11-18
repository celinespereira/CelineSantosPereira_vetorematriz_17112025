using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                const int QTD_COL = 3;
                const int QTD_LIN = 5;
                double[,] notas = new double[QTD_LIN, QTD_COL];

                notas = cadastrarNotas(QTD_LIN, QTD_COL);

                Console.WriteLine("\n *** Notas cadastradas na Matriz ***\n");
                exibirDados(notas);
                Console.ReadKey();
            }
        }

        static double[,] cadastrarNotas(int nLin, int nCol)
        {
            double[,] n = new double[nLin, nCol];
            for (int l = 0; 1 < nLin; l++)
            {
                Console.WriteLine("\nNotas do {0}? aluno", 1 + 1);
                for (int c = 0; c < nCol; c++)
                {
                    Console.Write(" {0}? nota: ", c + 1);
                    n[1, c] = double.Parse(Console.ReadLine());
                }
            }
            return n;
        }

        static void exibirDados(double[,] nt)
        {
            Console.WriteLine("\nAluno \t\thota1 \t\thota2 \t\thota3 \n");
            for (int i = 0; i < nt.GetLength(0); i++)
            {
                Console.Write("{0}%Aluno: ", i + 1);
                for (int j = 0; j < nt.GetLength(1); j++)
                {
                    Console.Write("\t{0:Mi}\t", nt[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}