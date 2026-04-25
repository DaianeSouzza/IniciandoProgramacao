using System;

class ConcatenarNome
{
    public static void Executar()
    {
        Console.Write("Digite seu nome: ");
        string nome = Console.ReadLine();

        Console.Write("Digite seu sobrenome: ");
        string sobrenome = Console.ReadLine();

        Console.WriteLine($"Nome completo: {nome} {sobrenome}");

        Console.ReadKey();
    }
}