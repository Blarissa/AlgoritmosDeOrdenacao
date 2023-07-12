using AlgoritmosDeOrdenacao;
using LarissaAtvOrdenação;
using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Serialization;

class Program
{
    static void Main()
    {
        //Iniciando vetores com itens de 100 a 200000

        string url = "..//dados100.txt";
        //EscreveArquivo(100, url);
        int[] vetor1 = ManipuladorDeArquivo.LerArquivo(url);

        url = "..//dados500.txt";        
        //EscreveArquivo(500, url);        
        int[] vetor2 = ManipuladorDeArquivo.LerArquivo(url);

        url = "..//dados1000.txt";
        //EscreveArquivo(1000, url);
        int[] vetor3 = ManipuladorDeArquivo.LerArquivo(url);

        url = "..//dados5000.txt";
        //EscreveArquivo(5000, url);
        int[] vetor4 = ManipuladorDeArquivo.LerArquivo(url);
    
        url = "..//dados10000.txt";
        //EscreveArquivo(10000, url);
        int[] vetor5 = ManipuladorDeArquivo.LerArquivo(url);

        url = "..//dados30000.txt";
        //EscreveArquivo(30000, url);
        int[] vetor6 = ManipuladorDeArquivo.LerArquivo(url);

        url = "..//dados50000.txt";
        //EscreveArquivo(50000, url);
        int[] vetor7 = ManipuladorDeArquivo.LerArquivo(url);
       
        url = "..//dados100000.txt";
        //EscreveArquivo(100000, url);
        int[] vetor8 = ManipuladorDeArquivo.LerArquivo(url);

        url = "..//dados150000.txt";
        //EscreveArquivo(150000, url);
        int[] vetor9 = ManipuladorDeArquivo.LerArquivo(url);

        url = "..//dados200000.txt";
        //EscreveArquivo(200000, url);
        int[] vetor10 = ManipuladorDeArquivo.LerArquivo(url);


        string algoritmo;

        //---------------BUBBLE SORT---------------    
        //algoritmo = "Bubble Sort";
        //Console.WriteLine(algoritmo.ToUpper());

        //// 100 elementos
        //ImprimeResultados(vetor1, Decrescente(vetor1),
        //    Aleatorio(vetor1), algoritmo, 100);

        //// 500 elementos
        //ImprimeResultados(vetor2, Decrescente(vetor2),
        //    Aleatorio(vetor2), algoritmo, 500);

        //// 1000 elementos
        //ImprimeResultados(vetor3, Decrescente(vetor3),
        //    Aleatorio(vetor3), algoritmo, 1000);

        //// 5000 elementos
        //ImprimeResultados(vetor4, Decrescente(vetor4),
        //    Aleatorio(vetor4), algoritmo, 5000);

        //// 10000 elementos
        //ImprimeResultados(vetor5, Decrescente(vetor5), 
        //    Aleatorio(vetor5), algoritmo, 10000);

        //// 30000 elementos
        //ImprimeResultados(vetor6, Decrescente(vetor6), 
        //    Aleatorio(vetor6), algoritmo, 30000);

        //// 50000 elementos
        //ImprimeResultados(vetor7, Decrescente(vetor7),
        //    Aleatorio(vetor7), algoritmo, 50000);

        //// 100000 elementos
        //ImprimeResultados(vetor8, Decrescente(vetor8),
        //    Aleatorio(vetor8), algoritmo, 100000);

        //// 150000 elementos
        //ImprimeResultados(vetor9, Decrescente(vetor9),
        //    Aleatorio(vetor9), algoritmo, 150000);

        //// 200000 elementos
        //ImprimeResultados(vetor10, Decrescente(vetor10), 
        //    Aleatorio(vetor10), algoritmo, 200000);

        ////---------------INSERTION SORT---------------
        //algoritmo = "Insertion Sort";

        //Console.WriteLine(algoritmo.ToUpper());

        //Console.WriteLine();
        //// 100 elementos
        //ImprimeResultados(vetor1, Decrescente(vetor1),
        //    Aleatorio(vetor1), algoritmo, 100);

        //// 500 elementos
        //ImprimeResultados(vetor2, Decrescente(vetor2),
        //    Aleatorio(vetor2), algoritmo, 500);

        //// 1000 elementos
        //ImprimeResultados(vetor3, Decrescente(vetor3),
        //    Aleatorio(vetor3), algoritmo, 1000);

        //// 5000 elementos
        //ImprimeResultados(vetor4, Decrescente(vetor4),
        //    Aleatorio(vetor4), algoritmo, 5000);

        //// 10000 elementos
        //ImprimeResultados(vetor5, Decrescente(vetor5),
        //    Aleatorio(vetor5), algoritmo, 10000);

        //// 30000 elementos
        //ImprimeResultados(vetor6, Decrescente(vetor6),
        //    Aleatorio(vetor6), algoritmo, 30000);

        //// 50000 elementos
        //ImprimeResultados(vetor7, Decrescente(vetor7),
        //    Aleatorio(vetor7), algoritmo, 50000);

        //// 100000 elementos
        //ImprimeResultados(vetor8, Decrescente(vetor8),
        //    Aleatorio(vetor8), algoritmo, 100000);

        //// 150000 elementos
        //ImprimeResultados(vetor9, Decrescente(vetor9),
        //    Aleatorio(vetor9), algoritmo, 150000);

        //// 200000 elementos
        //ImprimeResultados(vetor10, Decrescente(vetor10),
        //    Aleatorio(vetor10), algoritmo, 200000);

        ////---------------MERGE SORT---------------
        //algoritmo = "Merge Sort";

        //Console.WriteLine(algoritmo.ToUpper());

        //// 100 elementos
        //ImprimeResultados(vetor1, Decrescente(vetor1),
        //    Aleatorio(vetor1), algoritmo, 100);

        //// 500 elementos
        //ImprimeResultados(vetor2, Decrescente(vetor2),
        //    Aleatorio(vetor2), algoritmo, 500);

        //// 1000 elementos
        //ImprimeResultados(vetor3, Decrescente(vetor3),
        //    Aleatorio(vetor3), algoritmo, 1000);

        //// 5000 elementos
        //ImprimeResultados(vetor4, Decrescente(vetor4),
        //    Aleatorio(vetor4), algoritmo, 5000);

        //// 10000 elementos
        //ImprimeResultados(vetor5, Decrescente(vetor5),
        //    Aleatorio(vetor5), algoritmo, 10000);

        //// 30000 elementos
        //ImprimeResultados(vetor6, Decrescente(vetor6),
        //    Aleatorio(vetor6), algoritmo, 30000);

        //// 50000 elementos
        //ImprimeResultados(vetor7, Decrescente(vetor7),
        //    Aleatorio(vetor7), algoritmo, 50000);

        //// 100000 elementos
        //ImprimeResultados(vetor8, Decrescente(vetor8),
        //    Aleatorio(vetor8), algoritmo, 100000);

        //// 150000 elementos
        //ImprimeResultados(vetor9, Decrescente(vetor9),
        //    Aleatorio(vetor9), algoritmo, 150000);

        //// 200000 elementos
        //ImprimeResultados(vetor10, Decrescente(vetor10),
        //    Aleatorio(vetor10), algoritmo, 200000);

        //////---------------QUICK SORT---------------
        algoritmo = "Quick Sort";

        Console.WriteLine(algoritmo.ToUpper());

        //// 100 elementos
        //ImprimeResultados(vetor1, Decrescente(vetor1),
        //    Aleatorio(vetor1), algoritmo, 100);

        //// 500 elementos
        //ImprimeResultados(vetor2, Decrescente(vetor2),
        //    Aleatorio(vetor2), algoritmo, 500);

        //// 1000 elementos
        //ImprimeResultados(vetor3, Decrescente(vetor3),
        //    Aleatorio(vetor3), algoritmo, 1000);

        //// 5000 elementos
        //ImprimeResultados(vetor4, Decrescente(vetor4),
        //    Aleatorio(vetor4), algoritmo, 5000);

        //// 10000 elementos
        //ImprimeResultados(vetor5, Decrescente(vetor5),
        //    Aleatorio(vetor5), algoritmo, 10000);

        //// 30000 elementos
        //ImprimeResultados(vetor6, Decrescente(vetor6),
        //    Aleatorio(vetor6), algoritmo, 30000);

        // 50000 elementos
        ImprimeResultados(vetor7, Decrescente(vetor7),
            Aleatorio(vetor7), algoritmo, 50000);

        //// 100000 elementos
        //ImprimeResultados(vetor8, Decrescente(vetor8),
        //    Aleatorio(vetor8), algoritmo, 100000);

        ////150000 elementos
        //ImprimeResultados(vetor9, Decrescente(vetor9),
        //    Aleatorio(vetor9), algoritmo, 150000);

        //// 200000 elementos
        //ImprimeResultados(vetor10, Decrescente(vetor10),
        //    Aleatorio(vetor10), algoritmo, 200000);

        ////---------------HEAP SORT---------------
        //algoritmo = "Heap Sort";

        //Console.WriteLine(algoritmo.ToUpper());

        //// 100 elementos
        //ImprimeResultados(vetor1, Decrescente(vetor1),
        //    Aleatorio(vetor1), algoritmo, 100);

        //// 500 elementos
        //ImprimeResultados(vetor2, Decrescente(vetor2),
        //    Aleatorio(vetor2), algoritmo, 500);

        //// 1000 elementos
        //ImprimeResultados(vetor3, Decrescente(vetor3),
        //    Aleatorio(vetor3), algoritmo, 1000);

        //// 5000 elementos
        //ImprimeResultados(vetor4, Decrescente(vetor4),
        //    Aleatorio(vetor4), algoritmo, 5000);

        //// 10000 elementos
        //ImprimeResultados(vetor5, Decrescente(vetor5),
        //    Aleatorio(vetor5), algoritmo, 10000);

        //// 30000 elementos
        //ImprimeResultados(vetor6, Decrescente(vetor6),
        //    Aleatorio(vetor6), algoritmo, 30000);

        //// 50000 elementos
        //ImprimeResultados(vetor7, Decrescente(vetor7),
        //    Aleatorio(vetor7), algoritmo, 50000);

        //// 100000 elementos
        //ImprimeResultados(vetor8, Decrescente(vetor8),
        //    Aleatorio(vetor8), algoritmo, 100000);

        //// 150000 elementos
        //ImprimeResultados(vetor9, Decrescente(vetor9),
        //    Aleatorio(vetor9), algoritmo, 150000);

        //// 200000 elementos
        //ImprimeResultados(vetor10, Decrescente(vetor10),
        //    Aleatorio(vetor10), algoritmo, 200000);

        ////---------------Hibrido---------------
        //algoritmo = "Híbrido";

        //Console.WriteLine(algoritmo.ToUpper());

        //// 100 elementos
        //ImprimeResultados(vetor1, Decrescente(vetor1),
        //    Aleatorio(vetor1), algoritmo, 100);

        //// 500 elementos
        //ImprimeResultados(vetor2, Decrescente(vetor2),
        //    Aleatorio(vetor2), algoritmo, 500);

        //// 1000 elementos
        //ImprimeResultados(vetor3, Decrescente(vetor3),
        //    Aleatorio(vetor3), algoritmo, 1000);

        ////5000 elementos
        //ImprimeResultados(vetor4, Decrescente(vetor4),
        //  Aleatorio(vetor4), algoritmo, 5000);

        //// 10000 elementos
        //ImprimeResultados(vetor5, Decrescente(vetor5),
        //    Aleatorio(vetor5), algoritmo, 10000);

        //// 30000 elementos
        //ImprimeResultados(vetor6, Decrescente(vetor6),
        //    Aleatorio(vetor6), algoritmo, 30000);

        //// 50000 elementos
        //ImprimeResultados(vetor7, Decrescente(vetor7),
        //    Aleatorio(vetor7), algoritmo, 50000);

        //// 100000 elementos
        //ImprimeResultados(vetor8, Decrescente(vetor8),
        //    Aleatorio(vetor8), algoritmo, 100000);

        ////150000 elementos
        //ImprimeResultados(vetor9, Decrescente(vetor9),
        //    Aleatorio(vetor9), algoritmo, 150000);

        //// 200000 elementos
        //ImprimeResultados(vetor10, Decrescente(vetor10),
        //    Aleatorio(vetor10), algoritmo, 200000);
    }

    private static void EscreveArquivo(int i, string url)
    {
        Random random = new ();
        List<int> numeros = new() { };
        numeros.AddRange(Enumerable.Range(0, i));

        string texto = "";
        foreach (var n in numeros)
            texto += n.ToString() + " ";

        ManipuladorDeArquivo.EscreveArquivo(url, texto);
    }

    private static void ImprimeResultados(int[] crescente, 
        int[] decrescente, int[] aleatorio, string algoritmo, 
        int elementos)
    {
        TimeSpan tempo;

        Console.WriteLine($"\n{elementos} elementos:");

        //100 elementos      
        tempo = Testar(crescente, algoritmo);
        Console.WriteLine("Ordem crescente: " + tempo);

        tempo = Testar(decrescente, algoritmo);
        Console.WriteLine("Ordem decrescente: " + tempo);

        tempo = Testar(aleatorio, algoritmo);
        Console.WriteLine("Ordem aleatória: " + tempo);

        Console.WriteLine();
    }

    private static int[] Decrescente(int[] vetor)
    {       
        return vetor.OrderByDescending(x => x).ToArray();
    }

    private static int[] Aleatorio(int[] vetor)
    {
        Random random = new ();

        return vetor.OrderBy(x => random.Next()).ToArray();
    }

    private static TimeSpan Testar(int[] v, string algoritmo)
    {
        int comparacoes = 0;
        var stopwatch = new Stopwatch();
        TimeSpan tempo = TimeSpan.FromMilliseconds(0);

        switch (algoritmo)
        {
            case "Insertion Sort":

                stopwatch.Start();
                InsertionSort.Ordenar(v);
                stopwatch.Stop();

                tempo = stopwatch.Elapsed;
                break;

            case "Bubble Sort":

                stopwatch.Start();
                BubbleSort.Ordenar(v);
                stopwatch.Stop();                

                tempo = stopwatch.Elapsed;
                break;

            case "Merge Sort":

                stopwatch.Start();
                MergeSort.Ordenar(v, 0, v.Length - 1);
                stopwatch.Stop();

                tempo = stopwatch.Elapsed;
                break;

            case "Heap Sort":

                stopwatch.Start();
                HeapSort.Ordenar(v);
                stopwatch.Stop();

                tempo = stopwatch.Elapsed;
                break;

            case "Quick Sort":

                stopwatch.Start();
                QuickSort.Ordenar(v, 0, v.Length - 1);
                stopwatch.Stop();

                tempo = stopwatch.Elapsed;
                break;

            case "Híbrido":
                stopwatch.Start();
                Hibrido.Ordenar(v);
                stopwatch.Stop();

                tempo = stopwatch.Elapsed;
                break;
        }

        stopwatch.Reset();

        return tempo;
    }
}