using System;
class Program
{
    static void Main(string[] args)
    {
        // Operadores Lógicos
        && = // E
        || = // OU
        ! = // NÃO

        // Exemplo de && (E):

        Para obter uma habilitação é necessário:
        Ter 18 anos ou mais
        &&
        Ser aprovado no psicotécnico
        &&
        Aprovado no exame de Legislação
        &&
        Ser aprovado no exame de direção.
        // Todas as condições devem ser verdadeiras!
        
        // Exemplo de || (OU):

        //*Suponha X igual a 5*

        X <= 20 && X == 10 = false

        X > 0 && X != 3 = true

        X <= 20 && X == 10 && X != 3 = false

        // Tabela verdade  "&&"
        F + F = F
        F + V = F
        V + F = F
        V + V = V

        // Exemplos de "||"

        // Você pode estacionar na vaga especial se:
        For Idoso(a)
        ||
        For uma pessoa com deficiência
        ||
        For uma gestante

        // Exemplos do operador || (OU)
        // (Suponha que X = 5)
        X == 10 || X <= 20 = true
        X > 0 || X != 3 = true
        X <= 0 || X != 3 || X != 5 = true

        // Tabela verdade "||"
        F + F = F
        F + V = V
        V + F = V
        V + V = V

        // Exemplo de ! (NÃO)
        // Você tem direito a receber uma bolsa de estudos se você: (O operador ! inverte a condição)
        Não
        Possuir renda maior que $3.000,00

        // Exemplos do operador ! (NÃO)
        // (Suponha que X = 5)
        !(X == 10) = true
        !(X <= 20) = false
        !(X <= 20 && X== 10) = true

        // Tabela verdade "!" (NÃO)
        !F = V
        !V = F

        Aprendizado sobre operadores lógicos:
        && (e), || (ou), ! (não)
        // Tabela verdade
        // Exemplos de expressões lógicas
    }
}