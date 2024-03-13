namespace HelloWorldRocketseat.UseCases.CarLicensePlate;

public class CarLicensePlateUseCase
{
    public static void Execute()
    {
        Console.WriteLine("Digite a placa do seu carro: ");
        var carLicensePlate = Console.ReadLine();

        if (string.IsNullOrEmpty(carLicensePlate))
        {
            Console.WriteLine("Placa inválida");
            return;
        }

        carLicensePlate = carLicensePlate.ToUpper().Replace("-", "");

        bool has7AlphanumericChars = carLicensePlate.Length == 7;
        bool first3CharsAreLetters = char.IsLetter(carLicensePlate[0]) && char.IsLetter(carLicensePlate[1]) && char.IsLetter(carLicensePlate[2]);
        bool last4CharsAreNumbers = char.IsNumber(carLicensePlate[3]) && char.IsNumber(carLicensePlate[4]) && char.IsNumber(carLicensePlate[5]) && char.IsNumber(carLicensePlate[6]);

        if (!has7AlphanumericChars || !first3CharsAreLetters || !last4CharsAreNumbers)
        {
            Console.WriteLine("Placa inválida");
            return;
        }

        Console.WriteLine($"A placa do seu carro é válida: {carLicensePlate}");
    }
}
