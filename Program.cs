using HelloWorldRocketseat.UseCases.CarLicensePlate;
using HelloWorldRocketseat.UseCases.ConcatName;
using HelloWorldRocketseat.UseCases.CountTotalChars;
using HelloWorldRocketseat.UseCases.GetCurrentDateFormatted;
using HelloWorldRocketseat.UseCases.MathOperations;
using HelloWorldRocketseat.UseCases.WelcomeMessage;

namespace HelloWorldRocketseat;

class Program
{
    static void Main()
    {
        /*
         WelcomeMessage.Execute();
        Console.WriteLine();

        ConcatNameUseCase.Execute();
        Console.WriteLine();

        MathOperationsUseCase.Execute();
        Console.WriteLine();

        CountTotalCharsUseCase.Execute();
        Console.WriteLine();

        CarLicensePlateUseCase.Execute();
        Console.WriteLine();

        GetCurrentDateFormattedUseCase.Execute();
        Console.WriteLine();
        
         */

        Menu.Show();

        Console.ReadKey();
    }

}
