using LarissaAtvOrdenação;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AlgoritmosDeOrdenacao
{
    internal class Hibrido
    {
        private const int RUN_SIZE = 32;

        public static void Ordenar(int[] vetor)
        {
            int n = vetor.Length;
            for (int i = 0; i < n; i += RUN_SIZE)
                InsertionSort(vetor, i, Math.Min((i + RUN_SIZE - 1), (n - 1)));            

            for (int size = RUN_SIZE; size < n; size = 2 * size)            
                for (int esquerdo = 0; esquerdo < n; esquerdo += 2 * size)
                {
                    int meio = esquerdo + size - 1;
                    int direito = Math.Min((esquerdo + 2 * size - 1), (n - 1));

                    MergeSort.Ordenar(vetor, esquerdo, direito);
                }            
        }

        private static void InsertionSort(int[] vetor, int esquerdo, int direito)
        {
            for (int i = esquerdo + 1; i <= direito; i++)
            {
                int chave = vetor[i];
                int j = i - 1;

                while (j >= esquerdo && vetor[j] > chave)
                {
                    vetor[j + 1] = vetor[j];
                    j--;
                }

                vetor[j + 1] = chave;
            }
        }

        
        





    }
}
