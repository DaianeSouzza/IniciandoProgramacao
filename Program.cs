using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Escolha um exercício:");
        Console.WriteLine("1 - Boas-vindas");
        Console.WriteLine("2 - Concatenar nome");
        Console.WriteLine("3 - Operações com double");
        Console.WriteLine("4 - Contar caracteres");
        Console.WriteLine("5 - Validar placa");
        Console.WriteLine("6 - Data atual");

        string opcao = Console.ReadLine();

        switch (opcao)
        {
            case "1":
                BoasVindas.Executar();
                break;

            case "2":
                ConcatenarNome.Executar();
                break;

            case "3":
                OperacoesDouble.Executar();
                break;

            case "4":
                ContarCaracteres.Executar();
                break;

            case "5":
                ValidarPlaca.Executar();
                break;

            case "6":
                DataAtualFormatos.Executar();
                break;

            default:
                Console.WriteLine("Opção inválida.");
                break;
        }
    }
}