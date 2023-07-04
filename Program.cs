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
        //numeros.AddRange(Enumerable.Range(0, 500));

        string url = "..//dados500.txt";

        //ManipuladorDeArquivo.EscreveArquivo(url, texto);
        int[] vetor = ManipuladorDeArquivo.LerArquivo(url);

        //---------------BUBBLE SORT---------------    
        string algoritmo = "Bubble Sort";
        
        Console.WriteLine(algoritmo);

        Testa(vetor, algoritmo);

        //---------------INSERTION SORT---------------
        algoritmo = "Insertion Sort";
        
        Console.WriteLine(algoritmo);
        
        Testa(vetor, algoritmo);

        //---------------MERGE SORT---------------
        Console.WriteLine(algoritmo);
        
        algoritmo = "Merge Sort";
        
        Testa(vetor, algoritmo);

        //---------------QUICK SORT---------------
        algoritmo = "Quick Sort";
        
        Console.WriteLine(algoritmo);
        
        Testa(vetor, algoritmo);

        //---------------HEAP SORT---------------
        algoritmo = "Heap Sort";
        
        Console.WriteLine(algoritmo);
        
        Testa(vetor, algoritmo);

    }

    private static void Testa(int[] vetor, string algoritmo)
    {
        int[] v1 = Crescente(vetor),
              v2 = Decrescente(vetor),
              v3 = Aleatorio(vetor);

        var stopwatch = new Stopwatch();

        stopwatch.Start();
        BubbleSort.Ordenar(v1);
        stopwatch.Stop();

        Console.WriteLine($"Tempo de execução em ms do {algoritmo} com " +
                          $"vetor em ordem crescente: " +
                          $"{stopwatch.Elapsed}");


        stopwatch.Reset();
        stopwatch.Start();

        BubbleSort.Ordenar(v2);

        stopwatch.Stop();

        Console.WriteLine($"Tempo de execução em ms {algoritmo} com " +
                          $"vetor em ordem decrescente: " +
                          $"{stopwatch.Elapsed}");

        stopwatch.Reset();
        stopwatch.Start();

        BubbleSort.Ordenar(v3);

        stopwatch.Stop();

        Console.WriteLine($"Tempo de execução em ms do {algoritmo} com " +
                          $"vetor em ordem aleatória: " +
                          $"{stopwatch.Elapsed}\n");
        stopwatch.Reset();
    }

    private static int[] Crescente(int[] vetor)
    {
        return vetor.OrderBy(x => x).ToArray();
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
}