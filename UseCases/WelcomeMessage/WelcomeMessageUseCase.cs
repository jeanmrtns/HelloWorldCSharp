namespace HelloWorldRocketseat.UseCases.WelcomeMessage;

public class WelcomeMessage
{
    public static void Execute()
    {
        Console.WriteLine("Digite seu nome: ");
        var name = Console.ReadLine();

        if (string.IsNullOrEmpty(name))
        {
            Console.WriteLine("Nome inválido");
            Console.ReadKey();
            return;
        }

        Console.WriteLine($"Olá, {name}! Seja muito bem-vindo (a)!");
    }
}
