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
        public static int Ordenar(int[] vetor)
        {       
            int count = 0;

            for (int i = 1; i < vetor.Length; i++)
            {
                count ++;
                int chave = vetor[i];

                int j = i - 1;

                while(j >= 0 && vetor[j] < chave ) {
                    vetor[j + 1] = vetor[j];
                    j--;
                }

                vetor[j + 1] = chave;
            }
            return count;
        }
    }
}
