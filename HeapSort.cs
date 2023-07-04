using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LarissaAtvOrdenação
{
    public class HeapSort
    {
        public static void Ordenar(int[] vetor)
        {
            int n = vetor.Length;

            ConstroiHeapMax(vetor,n);

            for(int i = n - 1; i > 0; i--)
            {
                Trocar(vetor, i, 0);

                n --;
                
                RefazHeapMax(vetor, i, 0);
            }
        }

        private static void RefazHeapMax(int[] vetor, int n, int i)
        {
            int maior = i; 
            int esquerdo = 2 * i + 1; 
            int direito = 2 * i + 2;

            if (esquerdo < n && 
                vetor[esquerdo] > vetor[maior])
                maior = esquerdo;
            
            if (direito < n && 
                vetor[direito] > vetor[maior])
                maior = direito;

            if (maior != i)
            {
                Trocar(vetor, i, maior);
                RefazHeapMax(vetor, n, maior);
            }
        }

        private static void Trocar(int[] vetor, int i, int j)
        {
            int aux = vetor[i];
            vetor[i] = vetor[j];
            vetor[j] = aux;
        }

        private static void ConstroiHeapMax(int[] vetor, int n)
        {
            for (int i = n / 2 - 1; i >= 0; i--)
                RefazHeapMax(vetor, n, i);
        }
    }
}
