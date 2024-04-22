using System;
class program
{
    static void Main()
    {
        Console.WriteLine("Informe quantas números seram somandos: ");
        int n = int.Parse(Console.ReadLine());
        int soma = 0;
        
        for (int i = 0; i < n; i++)
        {
        Console.WriteLine("Informe o número:");
        int num = int.Parse(Console.ReadLine());
        soma += num;
        }
        Console.WriteLine("A soma dos números é: " + soma);
    }
}