﻿using System;
class program
{
    static void Main (string [] args)
    {
        int N;
        N = int.Parse(Console.ReadLine());
        string[] nomes = new string[N];
        int[] idades = new int[N];
        double[] alturas = new double[N];

         //Leitura dos dados
         for (int i=0; i<N; i++)
         {
            string[] s = Console.ReadLine().Split(' ');
            nomes[i] = s[0];
            idades[i] = int.Parse(s[1]);
            alturas[i] = double.Parse(s[2]); 
         }
         // Calculo da alturas media das pessoas
        double soma = 0;
        for (int i=0; i<N; i++)
        {
            soma += alturas[i];
        }
        double media = soma / N;

        Console.WriteLine("Altura média: " + media.ToString("F2"));

        //calculo da porcentagem de pessoas com idade menor que 16 anos
        int cont = 0;
        for (int i=0; i<N; i++)
        {
            if (idades[i] < 16)
            {
                cont++;
            }
        } 
        double porcentagem = (double)cont/N*100;
        Console.WriteLine("Pessoas com menos de 16 anos: " + porcentagem.ToString("F1") + "%");
    }
}
