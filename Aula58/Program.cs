using System;
class program
{
    static void Main (string [] args)
    {
        int N;
        double[] vet;

        // Lê a quantidade de valores
        N = int.Parse(Console.ReadLine());
        vet = new double[N];

        // Lê os valores e os armazena no vetor
        string[] s = Console.ReadLine().Split(' ');

        for (int i = 0; i < N; i++)
        {
            vet[i] = double.Parse(s[i]);
        }

        // Exibe os valores do vetor
        for (int i = 0; i < N; i++)
        {
            Console.Write(vet[i].ToString("F1") + " ");
        }
        
        Console.WriteLine();

        // Calcula a soma dos valores
        double soma = 0;
        for (int i = 0; i < N; i++)
        {
            soma += vet[i];
        }
        
        // Calcula a média dos valores
        double media = soma / N;

        // Exibe a soma e a média dos valores
        Console.WriteLine(soma.ToString("F2"));
        Console.WriteLine(media.ToString("F2"));

        Console.ReadLine();

    }
}
