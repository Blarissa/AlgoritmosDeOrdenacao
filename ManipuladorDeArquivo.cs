using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LarissaAtvOrdenação
{
    public class ManipuladorDeArquivo
    {
        public static int[] LerArquivo(string url)
        {
            var texto = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + url);
            var str = texto.Split(' ');

            int[] vetor = new int[str.Length - 1];

            for (int i = 0; i < str.Length - 1; i++)
                vetor[i] = int.Parse(str[i]);   

            return vetor;
        }

        public static void EscreveArquivo(string url, string texto)
        {
            File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + url, texto);
        }
    }
}
