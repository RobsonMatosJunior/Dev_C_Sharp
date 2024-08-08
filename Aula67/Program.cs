using System;
class program
{
    static void Main (string [] args)
    {
        int M, N; //M = número de linhas e N = número de colunas
        int [,] mat;

        string[] s = Console.ReadLine().Split(' ');
        M = int.Parse(s[0]); // Reading the number of lines and columns
        N = int.Parse(s[1]); // Reading the number of lines and columns
        mat = new int[M, N]; // Creating a matrix with M lines and N columns

        for (int i=0; i<M; i++)     // Reading the matrix
        {
            s = Console.ReadLine().Split(' '); // Splitting the string into an array of strings
            for (int j=0; j<N; j++)    // Reading the matrix
            {
                mat[i,j] = int.Parse(s[j]); // Converting the string to an integer
            }
        }

        int [] vet = new int [M]; // Creating a vector with M elements
        for(int i=0; i<M; i++)  // Summing the elements of each line and storing in the vector
        {
            int soma = 0; // Variable to store the sum of the elements of the line
            for (int j=0; j<N; j++) // Summing the elements of the line
            {
                soma += mat[i,j]; // Summing the elements of the line
            }
            vet[i] = soma; // Storing the sum of the elements of the line in the vector
        }
        for (int i=0; i<M; i++) // Printing the vector
        {
            Console.WriteLine(vet[i]); // Printing the vector
        }
        
        Console.ReadLine();
    }
}