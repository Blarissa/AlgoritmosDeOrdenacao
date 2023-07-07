using LarissaAtvOrdenação;
using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Serialization;

class Program
{
    static void Main()
    {
        //Random random = new Random();
        //List<int> numeros = new() { };
        //numeros.AddRange(Enumerable.Range(0, 100));

        //string texto = "";

        //foreach(var n in numeros)
        //    texto += n.ToString() + " ";


        string url1 = "..//dados100.txt";
        string url2 = "..//dados500.txt";

        // ManipuladorDeArquivo.EscreveArquivo(url1, texto);

        int[] vetor1 = ManipuladorDeArquivo.LerArquivo(url1);
        int[] crescente1 = vetor1,
              decrescente1 = Decrescente(vetor1),
              aleatorio1 = Aleatorio(vetor1);

        int[] vetor2 = ManipuladorDeArquivo.LerArquivo(url2);
        int[] crescente2 = vetor2,
              decrescente2 = Decrescente(vetor2),
              aleatorio2 = Aleatorio(vetor2);

       
        string algoritmo;

        //---------------BUBBLE SORT---------------    
        algoritmo = "Bubble Sort";
        Console.WriteLine(algoritmo.ToUpper());

        // 100 elementos
        ImprimeResultados(crescente1, decrescente1, 
            aleatorio1, algoritmo, 100);

        // 500 elementos
        ImprimeResultados(crescente2, decrescente2, 
            aleatorio2, algoritmo, 500);


        //---------------INSERTION SORT---------------
        algoritmo = "Insertion Sort";
        
        Console.WriteLine(algoritmo.ToUpper());

        // 100 elementos
        ImprimeResultados(crescente1, decrescente1, 
            aleatorio1, algoritmo, 100);

        // 500 elementos
        ImprimeResultados(crescente2, decrescente2,
            aleatorio2, algoritmo, 500);

        //---------------MERGE SORT---------------
        algoritmo = "Merge Sort";

        Console.WriteLine(algoritmo.ToUpper());

        // 100 elementos
        ImprimeResultados(crescente1, decrescente1, 
            aleatorio1, algoritmo, 100);

        // 500 elementos
        ImprimeResultados(crescente2, decrescente2, 
            aleatorio2, algoritmo, 500);

        ////---------------QUICK SORT---------------
        algoritmo = "Quick Sort";

        Console.WriteLine(algoritmo.ToUpper());

        // 100 elementos
        ImprimeResultados(crescente1, decrescente1, 
            aleatorio1, algoritmo, 100);

        // 500 elementos
        ImprimeResultados(crescente2, decrescente2, 
            aleatorio2, algoritmo, 500);

        //---------------HEAP SORT---------------
        algoritmo = "Heap Sort";

        Console.WriteLine(algoritmo.ToUpper());

        // 100 elementos
        ImprimeResultados(crescente1, decrescente1, 
            aleatorio1, algoritmo, 100);

        // 500 elementos
        ImprimeResultados(crescente2, decrescente2, 
            aleatorio2, algoritmo, 500);
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
        Random random = new Random();

        return vetor.OrderBy(x => random.Next()).ToArray();
    }

    private static TimeSpan Testar(int[] v, string algoritmo)
    {
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
        }

        stopwatch.Reset();

        return tempo;
    }
}