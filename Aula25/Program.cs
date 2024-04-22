using System;
    class Program
    {
        static void Main(string[] args)
        {
            string[] pessoa1 = Console.ReadLine().Split( ' ');
            string[] pessoa2 = Console.ReadLine().Split( ' ');

            string nome1 = pessoa1[0];
            string idade1 = pessoa1[1];
            string nome2 = pessoa2[0];
            string idade2 = pessoa2[1];

            decimal mediaidade = (decimal.Parse(idade1) + decimal.Parse(idade2)) / 2;

            Console.WriteLine("A idade média de " + nome1 + " e " + nome2 + " é de " + mediaidade.ToString("F1") + " anos. ");
            Console.ReadLine();

        }
    }