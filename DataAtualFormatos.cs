using System;

class DataAtualFormatos
{
    public static void Executar()
    {
        DateTime dataAtual = DateTime.Now;

        // Formato completo
        Console.WriteLine("Formato completo:");
        Console.WriteLine(dataAtual.ToString("dddd, dd MMMM yyyy HH:mm:ss"));

        // Apenas data
        Console.WriteLine("\nApenas data:");
        Console.WriteLine(dataAtual.ToString("dd/MM/yyyy"));

        // Apenas hora
        Console.WriteLine("\nApenas hora:");
        Console.WriteLine(dataAtual.ToString("HH:mm:ss"));

        // Data com mês por extenso
        Console.WriteLine("\nData com mês por extenso:");
        Console.WriteLine(dataAtual.ToString("dd 'de' MMMM 'de' yyyy"));

        Console.ReadKey();
    }
}