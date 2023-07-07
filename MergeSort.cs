using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LarissaAtvOrdenação
{
    public class MergeSort
    {
        /// <summary>
        /// Realiza a ordenação do vetor de inteiros.
        /// </summary>
        /// <param name="vetor">Vetor que vai ser ordenado. </param>
        /// <param name="primeiro">Índice do primeiro numero do vetor.</param>
        /// <param name="ultimo">Índice do último número do vetor.</param>
        public static void Ordenar(int[] vetor, int primeiro, int ultimo)
        {          
            if (primeiro < ultimo)
            {
                int meio = primeiro + (ultimo - primeiro)/2;
                
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
        private static void Combinar(int[] vetor, int primeiro, 
            int meio, int ultimo)
        {
            int n1 = meio - primeiro + 1;
            int n2 = ultimo - meio;

            int i, j;

            int[] esquerdo = new int[n1];
            int[] direito = new int[n2];

            for (i = 0; i < n1; i++)
                esquerdo[i] = vetor[primeiro + i];

            for (j = 0; j < n2; j++)
                direito[j] = vetor[meio + 1 + j];

            i = j = 0;

            int k = primeiro;

            while (i < n1 && j < n2)
            {
                if (esquerdo[i] <= direito[j])
                {
                    vetor[k] = esquerdo[i];
                    i++;
                }
                else
                {
                    vetor[k] = direito[j];
                    j++;
                }
                k++;
            }

            while (i < n1)
            {
                vetor[k] = esquerdo[i];
                i++;
                k++;
            }

            while (j < n2)
            {
                vetor[k] = direito[j];
                j++;
                k++;
            }
        }
    }
}
