// Problemas While
// Problema = 1114
/*
using System;
class Program
{
    static void Main (string [] args)
    {
        int senha = 2002;
        int entrada = int.Parse(Console.ReadLine());
        int cont = 0;
        while (entrada != senha)
        {
            cont = cont + 1;
            Console.WriteLine("Senha Invalida");
            entrada = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Acesso Permitido");
        Console.WriteLine("Tentativas até o sucesso: " + cont);
    }
}
*/

// PROBLEMA = 1115

/*
using System;
class Program
{
    static void Main (string [] args)
    {
        int x, y;
        string [] valores = Console.ReadLine().Split(' ');
        x = int.Parse(valores[0]);
        y = int.Parse(valores[1]);

        while (x != 0 && y != 0)
        {
            if (x > 0 && y > 0)
            {
                Console.WriteLine("primeiro");
                
            }
            else if (x < 0  &&  y > 0)
            {
                Console.WriteLine("segundo");
                
            }
            else if ( x < 0 &&  y < 0)
            {
                Console.WriteLine("terceiro");
            }
            else
            {
                Console.WriteLine("quarto");
                
            }
            valores = Console.ReadLine().Split(' ');
            x = int.Parse(valores[0]);
            y = int.Parse(valores[1]);
        }
        Console.ReadLine();
    }
}
*/
/*
using System;
class Program
{
    static void Main (string [] args)
    {
        double nota1 = -1, nota2 = -1;
        
        while (true)
        {
            double entrada = double.Parse(Console.ReadLine());
            if (nota1 == -1)
            {
                if (entrada >= 0 && entrada <= 10)
                {
                    nota1 = entrada;
                }
                else
                {
                    Console.WriteLine("nota invalida");
                }
            }
            else if (nota2 == -1)
            {
               if (entrada >= 0 && entrada <= 10)
               {
                    nota2 = entrada;
                    break;
               }
               else
               {
                    Console.WriteLine("nota invalida");
               }
            }
            
        }
        
        double media = (nota1 + nota2) / 2;
        Console.WriteLine("media = " + media.ToString("F2"));
    }
}
*/

/*
using System;
class Program
{
    static void Main (string [] args)
    {
        int alcool, gasolina, diesel, entrada;
        alcool = 0;
        gasolina = 0;
        diesel = 0;
        entrada = 0;
        
        while (entrada != 4)
        {
            entrada = int.Parse(Console.ReadLine());

            if (entrada == 1)
            {
                alcool = alcool + 1;
            }
            else if (entrada == 2)
            {
                gasolina = gasolina + 1;
            }
            else if (entrada == 3)
            {
                diesel = diesel + 1;
            }
        }
        Console.WriteLine("MUITO OBRIGADO");
        Console.WriteLine("Alcool: " + alcool);
        Console.WriteLine("Gasolina: " + gasolina);
        Console.WriteLine("Diesel: " + diesel);
        Console.ReadLine();
    }
}
*/

