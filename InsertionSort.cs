using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LarissaAtvOrdenação
{
    public class InsertionSort
    {
        public static int comparacoes = 0;

        public static void Ordenar(int[] vetor)
        {    
           for (int i = 1; i < vetor.Length; i++)
           {                
                int chave = vetor[i];

                int j = i - 1;

                while(j >= 0 && vetor[j] < chave ) {
                    vetor[j + 1] = vetor[j];
                    j--;
                    comparacoes++;
                }

                vetor[j + 1] = chave;
           }
        }
    }
}
