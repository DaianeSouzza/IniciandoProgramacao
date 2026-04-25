using System;

class OperacoesDouble
{
    public static void Executar()
    {
        // Valores já declarados
        double numero1 = 10.5;
        double numero2 = 2.5;

        // Soma
        double soma = numero1 + numero2;

        // Subtração
        double subtracao = numero1 - numero2;

        // Multiplicação
        double multiplicacao = numero1 * numero2;

        // Divisão (com verificação)
        double divisao = 0;

        if (numero2 != 0)
        {
            divisao = numero1 / numero2;
        }
        else
        {
            Console.WriteLine("Não é possível dividir por zero.");
        }

        // Média
        double media = (numero1 + numero2) / 2;

        // Exibir resultados
        Console.WriteLine($"Número 1: {numero1}");
        Console.WriteLine($"Número 2: {numero2}");

        Console.WriteLine($"Soma: {soma}");
        Console.WriteLine($"Subtração: {subtracao}");
        Console.WriteLine($"Multiplicação: {multiplicacao}");

        if (numero2 != 0)
        {
            Console.WriteLine($"Divisão: {divisao}");
        }

        Console.WriteLine($"Média: {media}");

        Console.ReadKey();
    }
}