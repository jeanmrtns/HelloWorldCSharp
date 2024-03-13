using HelloWorldRocketseat.UseCases.CarLicensePlate;
using HelloWorldRocketseat.UseCases.ConcatName;
using HelloWorldRocketseat.UseCases.CountTotalChars;
using HelloWorldRocketseat.UseCases.MathOperations;
using HelloWorldRocketseat.UseCases.WelcomeMessage;

namespace HelloWorldRocketseat;

public class Menu
{
    public static void Show()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        
        Console.WriteLine("Informe a aplicação desejada: ");
        Console.WriteLine("1 - Mensagem de bem-vindo");
        Console.WriteLine("2 - Concatenação de nome");
        Console.WriteLine("3 - Operações matemáticas");
        Console.WriteLine("4 - Tamanho de um texto");
        Console.WriteLine("5 - Validação de placas de carros");
        Console.WriteLine("6 - Data atual formatada");
        Console.WriteLine("0 - Sair\n\n");

        var option = int.Parse(Console.ReadLine());
        switch (option)
        {
            case 1:
                WelcomeMessage.Execute();
                break;
            case 2:
                ConcatNameUseCase.Execute();
                break;
            case 3:
                MathOperationsUseCase.Execute();
                break;
            case 4:
                CountTotalCharsUseCase.Execute();
                break;
            case 5:
                CarLicensePlateUseCase.Execute();
                break;
            case 0:
                System.Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Opção inválida");
                break;
        }

        Console.WriteLine("\n\n");
        Show();
    }
}
