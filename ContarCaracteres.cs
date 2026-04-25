using System;

class ContarCaracteres
{
    public static void Executar()
    {
        Console.Write("Digite uma palavra ou frase: ");
        string texto = Console.ReadLine();

        int contador = 0;

        // Conta apenas caracteres diferentes de espaço
        foreach (char c in texto)
        {
            if (c != ' ')
            {
                contador++;
            }
        }

        Console.WriteLine($"Quantidade de caracteres (sem espaços): {contador}");

        Console.ReadKey();
    }
}