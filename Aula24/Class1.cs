using System;
using System.Globalization;

namespace aula25;
{
    class Program
    {
        static void Main(string[] args)
        {
            // Questionnaire
            Console.WriteLine("Entre com seu nome!");
            string nome = Console.ReadLine();
            Console.WriteLine("Quantos Quartos tem na sua casa?");
            int quartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto!");
            string precoInput = Console.ReadLine().Replace(',', '.'); // Substituir vírgula por ponto
            double preco = double.Parse(precoInput, CultureInfo.InvariantCulture);
            Console.WriteLine("Entre seu último nome, idade e altura (mesma linha)!");
            string[] vet = Console.ReadLine().Split(' ');
            string sobrenome = vet[0];
            int idade = int.Parse(vet[1]);
            string alturaInput = vet[2].Replace(',', '.');
            double altura = double.Parse(alturaInput, CultureInfo.InvariantCulture);


            //Answer + content
            Console.WriteLine("Seu nome é: " + nome);
            Console.WriteLine("Em sua casa tem: " + quartos + " quartos!");
            Console.WriteLine("O preço do produto é: " + preco.ToString("F2", CultureInfo.GetCultureInfo("pt-BR"))); 
            Console.WriteLine("Seu Sobrenome é: " + sobrenome);
            Console.WriteLine("Sua idade é: " + idade);
            Console.WriteLine("Você mede: " + altura.ToString("F2", CultureInfo.GetCultureInfo("pt-BR")));

        }
    }
}

