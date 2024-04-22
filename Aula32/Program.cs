
// Estrutura condicional

// Sintaxe da estrutura condicional:

// True = executa o bloco de comandos
// False = pula o bloco de comandos
// Exemplo simples:
/* Simples:
    if (<condição>){
        <comando 1>
        <comando 2>
    } */

/* using System;
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            Console.WriteLine("Bom dia!");
            if (x<0) 
            // Se o retorno for verdadeiro será impresso a mensagem.
            {
                Console.WriteLine("Boa tarde");
            }
            else
            {

            }

            Console.WriteLine("Boa noite");

            Console.ReadLine();
        }
    } */

    using System;
    class Program
    {
        static void Main(string[] args)
        {
            int horas;
            Console.WriteLine("Quantas horas?");
            horas = int.Parse(Console.ReadLine());
            if (horas < 12)
            {
                Console.WriteLine("Bom dia!");
            }
            else if (horas <= 18)
            {
                Console.WriteLine("Boa tarde!");
            }
            else
            {
                Console.WriteLine("Boa noite!");
            }
            Console.ReadLine();
        }
    }

/*
    Estruturas condicionais Simples
    Estruturas condicionais compostas
    Encadeamento de estruturas condicionais
*/
