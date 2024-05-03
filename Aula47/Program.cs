using System;


class program
{
    static void Main(string [] args)
    {
        
        // Problema 1078
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i + " x " + n + " = " + i * n);
        }

        Console.ReadLine();
    }
}