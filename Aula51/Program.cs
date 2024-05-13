using System;
class program
{
    static void Main(string [] args)
    {
        double C;
        double F;
        char repetir;

        do
        {
            Console.WriteLine("DIgite a Temperatura em Celsius: ");
            C= double.Parse(Console.ReadLine());
            F = 9.0 * C / 5.0 + 32.0;
            Console.WriteLine("Equivalente em fairheint é: " + F.ToString("F1"));

            Console.WriteLine("Deseja repetir (s/n)?");
            repetir = char.Parse(Console.ReadLine());
        }

        while (repetir == 's');
        Console.ReadLine();
        

    }
}