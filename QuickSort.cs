using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LarissaAtvOrdenação
{
    public class QuickSort
    {              
        public static void Ordenar(int[] vetor, int primeiro, int ultimo)
        {
            if (primeiro < ultimo)
            {
                int meio = Divide(vetor, primeiro, ultimo);
                
                Ordenar(vetor, primeiro, meio - 1);
                Ordenar(vetor, meio + 1, ultimo);
            }    
        }

        private static int Divide(int[] vetor, int primeiro, int ultimo)
        {
            int x = vetor[ultimo];
            int i = primeiro - 1;

            for(int j = primeiro; j < ultimo; j++)            
                if (vetor[j] <= x)
                {
                    i++;
                    Trocar(vetor, i, j);
                }

            Trocar(vetor, i + 1, ultimo);

            return i + 1;
        }

        private static void Trocar(int[] vetor, int i, int j)
        {
            int aux = vetor[i];

            vetor[i] = vetor[j];
            vetor[j] = aux;
        }
    }
}
