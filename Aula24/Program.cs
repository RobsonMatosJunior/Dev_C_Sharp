using System;
    class program
    {
        static void Main(string [] args)
        {
            double b = double.Parse(Console.ReadLine());
            double a = double.Parse(Console.ReadLine());

            double area = a * b;
            double perimetro = 2 * (a+ b );
            double diagonal = Math.Sqrt(Math.Pow(a,2) + Math.Pow(b,2)); 

            Console.WriteLine("Area = " + area.ToString("F4"));
            Console.WriteLine("Perimetro = " + perimetro.ToString("F4"));
            Console.WriteLine("Diagonal = " + diagonal.ToString("F4"));

            Console.ReadLine();

        }
    }