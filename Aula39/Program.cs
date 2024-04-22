/*while("Condição")
        {
            "Comando 1"
            "Comando 2"
            A condição é testada e se for verdadeira retorna e testa novamente, repete-se até o resultado ser falso. 
        } 
        */ 

using System;
class program
{
    static void Main(string[] args)
    {
        int x, soma;
        Console.WriteLine("Digite um número:");
        x = int.Parse(Console.ReadLine());
        soma = 0;
        while(x != 0)
        {
            soma = soma + x;
            
            Console.WriteLine("Digite um número:");
            x = int.Parse(Console.ReadLine());
        }
        Console.WriteLine(soma);
        Console.ReadLine();
    }
}

