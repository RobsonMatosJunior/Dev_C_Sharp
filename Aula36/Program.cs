using System;
class program
{
    static void Main(string[] args)
    {
        int minutos;
        double conta;

        minutos = int.Parse(Console.ReadLine());
        conta = 50.0;
        if (minutos > 100)
        {
            conta = conta + (minutos - 100) * 2.0;
        }
        Console.WriteLine("Valor a pagar: R$ " + conta.ToString("F2"));
        Console.ReadLine();
    }
}

/*
    conta += (minutos - 100) * 2.0; - sintaxe de atribuição
    Operadores de atribuição cumulativa:
    a += b; // a = a + b;
    a -= b; // a = a - b;
    a *= b; // a = a * b;
    a /= b; // a = a / b;
    a %= b; // a = a % b;
*/