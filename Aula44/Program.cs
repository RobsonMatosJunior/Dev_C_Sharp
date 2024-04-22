using System;
using System.Collections.Generic;
class Program
{
    static void Main( string [] args)
    {
        double idade, soma, media;
        int cont;

        idade = double.Parse(Console.ReadLine());
        soma = 0.0;
        cont = 0;

        while (idade >= 0)
        {
            cont = cont +1;
            soma = soma + idade;
            idade = double.Parse(Console.ReadLine());


        }
        if (cont == 0)
        {
            Console.WriteLine("Impossivel calcular");
        }
        else
        {
            media = soma / cont;
            Console.WriteLine(media.ToString("F2"));
        }
        
        Console.ReadLine();

    }
}
