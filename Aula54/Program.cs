using System;
class Program
{
    static void Main()
    {
        /*
        int[] A;
        double [] B;
        string [] C;

        A = new int[10];
        B = new double[5];
        C = new string[3];

        A[3] = 10;
        for (int i = 0; i<5; i++)
        {
            B[i] = i + 10;
        }
        
        C[1] = "Maria";
        */

        int N;
        double[] vet;
        N = int.Parse(Console.ReadLine());
        vet = new double[N];
       
        for (int i = 0; i<N; i++)
        {
            vet[i] = double.Parse(Console.ReadLine());
        }

        for (int i = 0; i<N; i++)
        {
            Console.WriteLine(vet[i].ToString("F1"));
        }

        Console.ReadLine();
    }
}


