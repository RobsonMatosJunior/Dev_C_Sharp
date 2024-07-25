// Aula sobre Matrizes

using System;
class program
{
    static void Main (string [] args)
    {
        /*
        double[,] A;
        A = new double[3, 4];
        A[1, 2] = 10;
        */

        int M, N;
        int [,] A;

        M = int.Parse(Console.ReadLine());
        N = int.Parse(Console.ReadLine());
        A = new int[M, N];

        for (int i = 0; i< M; i++)
        {
            string[] s = Console.ReadLine().Split(' ');
            for (int j = 0; j < N; j++)
            {
                A[i, j] = int.Parse(s[j]);        
            }
        }
        
        Console.WriteLine("Impressa a Matriz fica :");

        for (int i = 0; i < M; i++)
        {
            for (int j = 0; j < N; j++)
            {
                Console.Write(A [i, j] + " ");
            }
            Console.WriteLine();
        }
        
        Console.ReadLine();


    }
}