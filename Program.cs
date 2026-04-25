using System;

class Program
{
    static void Main()

      {
        // Solicita o nome do usuário
        Console.Write("Digite seu nome: ");
        string nome = Console.ReadLine();

        // Exibe mensagem personalizada
        Console.WriteLine($"Olá, {nome}! Seja muito bem-vindo!");

        // Pausa para visualizar o resultado
        Console.ReadKey();
    }
}