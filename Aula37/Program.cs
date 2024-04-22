using System;
class program
{
    static void Main(string[] args)
    {
        //Switch Case
        /*int X = int.Parse(Console.ReadLine());
        string dia;
        if (X==1)
        {
            dia = "Domingo";
        }
        else if (X==2)
        {
            dia = "Segunda";
        }
        else if (X==3)
        {
            dia = "Terça";
        }
        else if (X==4)
        {
            dia = "Quarta";
        }
        else if (X==5)
        {
            dia = "Quinta";
        }
        else if (X==6)
        {
            dia = "Sexta";
        }
        else if (X==7)
        {
            dia = "Sábado";
        }
        else
        {
            dia = "Valor inválido";
        }
        Console.WriteLine("Dia da semana: " + dia);
        Console.ReadLine();*/

        int x = int.Parse(Console.ReadLine());
        string dia;
        switch (x)
        {
            case 1:
                dia = "Domingo";
            break;
            case 2:
                dia = "Segunda";
            break;
            case 3:
                dia = "Terça";
            break;
            case 4:
                dia = "Quarta";
            break;
            case 5:
                dia = "Quinta";
            break;
            case 6:
                dia = "Sexta";
            break;
            case 7:
                dia = "Sábado";
            break;
            default:
                dia = "Valor inválido";
            break;
        }
        Console.WriteLine("Dia da semana: " + dia);
        Console.ReadLine();
    }
}