using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LarissaAtvOrdenação
{
    public class BubbleSort
    {
        public static void Ordenar(int[] vetor)
        {
            int n = vetor.Length;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (vetor[j] > vetor[j + 1])
                    {
                        Trocar(vetor, j);
                    }
                }
            }
        }

        private static void Trocar(int[] vetor, int j)
        {
            int aux = vetor[j];
            vetor[j] = vetor[j + 1];
            vetor[j + 1] = aux;
        }
    }
}
