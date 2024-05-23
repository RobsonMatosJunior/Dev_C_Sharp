using System;
class program
{
    static void Main (string [] args)
    {
        int N;
        double soma;
        double[] vet;

        N = int.Parse(Console.ReadLine());
        vet = new double[N];

        string[] s = Console.ReadLine().Split("");

        soma = 0;
        for (int i=0; i<N; i++)
        {
            vet[i] = double.Parse(s[i]);
        }

        Console.WriteLine(s);
        Console.ReadLine();
    }
}
