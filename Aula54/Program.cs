using System;
class Program
{
    static void Main()
    {
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
    }
}