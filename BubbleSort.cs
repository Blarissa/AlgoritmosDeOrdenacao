using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LarissaAtvOrdenação
{
    public class BubbleSort
    {
        public static int comparacoes = 0;

        public static void Ordenar(int[] vetor)
        {
            int count = 0;
            int n = vetor.Length;
            bool trocou;
            
            for (int i = 0; i < n - 1; i++)
            {
                trocou = false;
                for (int j = 0; j < n - i - 1; j++)
                {
                    comparacoes++;
                    if (vetor[j] > vetor[j + 1])
                    {
                        Trocar(vetor, j);
                        trocou = true;
                    }
                }
                
                if (!trocou)
                    break;
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
