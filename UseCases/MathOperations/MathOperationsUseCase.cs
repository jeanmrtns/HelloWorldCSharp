namespace HelloWorldRocketseat.UseCases.MathOperations;

public class MathOperationsUseCase
{
    public static void Execute()
    {
        var allowedOperations = new List<char> { '+', '-', '*', '/' };

        Console.WriteLine("Digite o primeiro número: ");
        var number1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o segundo número: ");
        var number2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite a operação desejada (+, -, *, /): ");
        var operation = char.Parse(Console.ReadLine());
        
        if (!allowedOperations.Contains(operation))
        {
            Console.WriteLine("Operação inválida");
            Console.ReadKey();
            return;
        }

        double operationResponse = 0.0;
        

        switch (operation)
        {
            case '+':
                operationResponse = number1 + number2;
                break;
            case '-':
                operationResponse = number1 - number2;
                break;
            case '*':
                operationResponse = number1 * number2;
                break;
            case '/':
                operationResponse = number1 / number2;
                break;
            default:
                Console.WriteLine("Operação inválida");
                break;
        }

        Console.WriteLine($"O resultado da operação ({number1} {operation} {number2}) é: {operationResponse}");
    }
}
