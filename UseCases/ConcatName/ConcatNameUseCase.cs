using System.Xml.Linq;

namespace HelloWorldRocketseat.UseCases.ConcatName;

public class ConcatNameUseCase
{
    public static void Execute()
    {
        Console.WriteLine("Digite seu nome: ");
        var firstName = Console.ReadLine();

        Console.WriteLine("Digite seu sobrenome: ");
        var lastName = Console.ReadLine();

        if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
        {
            Console.WriteLine("Nome ou sobrenome inválido");
            Console.ReadKey();
            return;
        }

        string fullName = $"{firstName} {lastName}";
        Console.WriteLine($"Seu nome completo é: {fullName}");
    }
}
