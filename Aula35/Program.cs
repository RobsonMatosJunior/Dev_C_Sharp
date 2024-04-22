using System;
class Program
{
    static void Main(string[] args)
    {
        int X, Y, Z;
        string[] leitura = Console.ReadLine().Split(' ');
        X = int.Parse(leitura[0]);
        Y = int.Parse(leitura[1]);
        Z = int.Parse(leitura[2]);

        if (X < Y && X < Z)
        {
            Console.WriteLine("MENOR = " + X);
        }
        else if (Y < X && Y < Z)
        {
            Console.WriteLine("MENOR = " + Y);
        }
        else
        {
            Console.WriteLine("MENOR = " + Z);
        }
        
        Console.ReadLine();
    }
}