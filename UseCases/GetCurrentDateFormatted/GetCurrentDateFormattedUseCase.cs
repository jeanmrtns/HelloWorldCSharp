using System.Globalization;

namespace HelloWorldRocketseat.UseCases.GetCurrentDateFormatted;

public class GetCurrentDateFormattedUseCase
{
    public static void Execute()
    {
        Console.WriteLine("Informe o tipo de data desejado:");
        Console.WriteLine("1 - Formato completo (dia da semana, dia do mês, mês, ano, hora, minutos, segundos).");
        Console.WriteLine("2 - Apenas a data no formato \"01/03/2024\"");
        Console.WriteLine("3 - Apenas a hora no formato de 24 horas.");
        Console.WriteLine("4 - A data com o mês por extenso.");
        var option = int.Parse(Console.ReadLine());
        
        var currentDate = DateTime.Now;
        string formattedDate = string.Empty;

        switch (option)
        {
            case 1:
                formattedDate = currentDate.ToString("dddd, dd/MM/yyyy HH:mm:ss");
                break;
            case 2:
                formattedDate = currentDate.ToString("dd/MM/yyyy");
                break;
            case 3:
                formattedDate = currentDate.ToString("HH");
                break;
            case 4:
                formattedDate = currentDate.ToString("dd/MMMM/yyyy");
                break;
            default:
                Console.WriteLine("Opção inválida");
                break;
        }
        
        Console.WriteLine($"A data atual é: {formattedDate}");
    }
}
