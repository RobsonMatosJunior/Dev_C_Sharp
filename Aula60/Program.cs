﻿using System;
class program
{
    static void Main (string [] args)
    {
        int N;
        N = int.Parse(Console.ReadLine());

        string[] vet = new string[N];
        
        for (int i = 0; i<N; i++)
        {
            vet[i] = Console.ReadLine();
        }

        Console.WriteLine("Nomes lidos: ");
        foreach (string value in vet)
        {
            Console.WriteLine(value);  
        }
        Console.ReadLine();
    }
}