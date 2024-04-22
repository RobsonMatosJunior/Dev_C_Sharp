using System;
class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite as notas");
        double nota1 = double.Parse(Console.ReadLine());
        double nota2 = double.Parse(Console.ReadLine());
        double notaFinal = (nota1 + nota2);

        if (notaFinal <= 60.0)
        {
            Console.WriteLine("NOTA FINAL = " + notaFinal.ToString("F1"));
            Console.WriteLine("Reprovado");
        }
        else
        {
            Console.WriteLine("NOTA FINAL = " + notaFinal);
        }
    }
}