using System;
class program
{
    static void Main (string [] args)
    {
        int M, N;
        int [,] mat;

        string[] s = Console.ReadLine()Split(' ');
        M = int.Parse(s[0]);
        N = int.Parse(s[1]);

        for (int i=0; i<M; i++)
        {
            s = Console.ReadLine().Split(' '); // Splitting the string into an array of strings
            for (int j=0; j<N; j++)
            {
                mat[i,j] = int.Parse(s[j]);
            }
        }

        int [] vet = new int [M];
        for(int i=0; i<M; i++)
        {
            int soma = 0;
            for (int j=0; j<N; j++)
            {
                soma += mat[i,j];
            }
            vet[i] = soma;
        }
        for (int i=0; i<M; i++)
        {
            Console.WriteLine(vet[i]);
        }
        
        Console.ReadLine();
    }
}