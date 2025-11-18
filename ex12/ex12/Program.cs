using System;
using System.Threading;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            const int QTD_COL = 3;
            const int QTD_LIN = 3;
            int[,] matriz = new int[QTD_LIN, QTD_COL];
            matriz = cadastrarNumeros(QTD_LIN, QTD_COL);

            Console.WriteLine("\n---MEMORIZE---\n");
            exibirDados(matriz);

            Thread.Sleep(5000);
            Console.Clear();

            int sorteioLinha = random.Next(0, QTD_LIN);
            int sorteioColuna = random.Next(0, QTD_COL);

            Console.Write("\nQual número consta na posição: linha {0}, coluna {1} da matriz: ", sorteioLinha, sorteioColuna);
            int num = int.Parse(Console.ReadLine());

            if (verifica(matriz[sorteioLinha, sorteioColuna], num) == true)
                Console.WriteLine("\nParabéns! Você acertou!\n");
            else
                Console.WriteLine("\nQue pena! Você errou! Número correto seria: {0}\n", matriz[sorteioLinha, sorteioColuna]);

            exibirDados(matriz);
            Console.ReadKey();
        }

        static int[,] cadastrarNumeros(int nLin, int nCol)
        {
            int[,] n = new int[nLin, nCol];
            Random random = new Random();
            for (int l = 0; l < nLin; l++)
            {
                for (int c = 0; c < nCol; c++)
                {
                    n[l, c] = random.Next(0, 50);
                }
            }
            return n;
        }

        static Boolean verifica(int numeroMatrix, int numUsuario)
        {
            return numeroMatrix == numUsuario ? true : false;
        }

        static void exibirDados(int[,] n)
        {
            for (int i = 0; i < n.GetLength(0); i++)
            {
                for (int j = 0; j < n.GetLength(1); j++)
                {
                    Console.Write("{0:00} ", n[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}