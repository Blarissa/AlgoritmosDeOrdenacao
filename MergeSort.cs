using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LarissaAtvOrdenação
{
    public class MergeSort
    {
        public static void Ordenar(int[] vetor, int primeiro, int ultimo)
        {          
            if (primeiro < ultimo)
            {
                int meio = (primeiro + ultimo) / 2;
                
                Ordenar(vetor, primeiro, meio);
                Ordenar(vetor, meio + 1, ultimo); 
                
                Combinar(vetor, primeiro, meio, ultimo);
            }
        }

        /// <summary>
        /// Método que realiza a união das duas metades ordenadas.
        /// </summary>
        /// <param name="vetor">Vetor com os valores ordenados.</param>
        /// <param name="primeiro"> Índice do primeiro elemento do vetor.</param>
        /// <param name="meio">Índice da metade do vetor. </param>
        /// <param name="ultimo">Índice do último elemento do vetor. </param>
        private static void Combinar(int[] vetor, int primeiro, int meio, int ultimo)
        {
            int n1 = meio - primeiro + 1;
            int n2 = ultimo - meio;
            int[] temp = new int[ultimo - primeiro + 1];

            int i, j;

            int[] direito = new int[n1];
            int[] esquerdo = new int[n2];

            for (i = 0; i < n1; i++)
                direito[i] = vetor[primeiro + i];

            for (j = 0; j < n2; j++)
                esquerdo[j] = vetor[meio + 1 + j];

            i = 0; j = 0;

            int k = primeiro;

            while (i < n1 && j < n2)
            {
                if (direito[i] <= esquerdo[j])
                {
                    vetor[k] = direito[i];
                    i++;
                }
                else
                {
                    vetor[k] = esquerdo[j];
                    j++;
                }

                k++;
            }

            while (i < n1)
            {
                vetor[k] = direito[i];
                i++;
                k++;
            }

            while (i < n2)
            {
                vetor[k] = esquerdo[j];
                j++;
                k++;
            }

        }
    }
}
