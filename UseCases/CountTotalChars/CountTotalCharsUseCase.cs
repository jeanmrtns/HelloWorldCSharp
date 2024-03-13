namespace HelloWorldRocketseat.UseCases.CountTotalChars;

public class CountTotalCharsUseCase
{
    public static void Execute()
    {
        Console.WriteLine("Digite uma palavra ou texto: ");
        var text = Console.ReadLine();

        if (string.IsNullOrEmpty(text))
        {
            Console.WriteLine("Texto inválido");
            Console.ReadKey();
            return;
        }

        int totalChars = text.Length;
        Console.WriteLine($"O total de caracteres digitados é: {totalChars}");
    }
}
