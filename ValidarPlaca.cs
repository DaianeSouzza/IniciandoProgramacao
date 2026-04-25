using System;

class ValidarPlaca
{
    public static void Executar()
    {
        Console.Write("Digite a placa do veículo: ");
        string placa = Console.ReadLine();

        bool placaValida = true;

        if (placa.Length != 7)
        {
            placaValida = false;
        }
        else
        {
            // Verifica as 3 primeiras letras
            for (int i = 0; i < 3; i++)
            {
                if (!char.IsLetter(placa[i]))
                {
                    placaValida = false;
                }
            }

            // Verifica os 4 últimos números
            for (int i = 3; i < 7; i++)
            {
                if (!char.IsDigit(placa[i]))
                {
                    placaValida = false;
                }
            }
        }

        Console.WriteLine(placaValida ? "Verdadeiro" : "Falso");

        Console.ReadKey();
    }
}