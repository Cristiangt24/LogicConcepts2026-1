using Shared;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    Console.WriteLine("Hola este es el sistema del Valor de Matricula!");
    var Credits = ConsoleExtension.GetInt("Ingrese el numero de Creditos a Matricular: ");
    var CreditCost = ConsoleExtension.GetDecimal("Ingrese el valor del credito: ");
    var StudentStratum = ConsoleExtension.GetInt("Ingrese el estrato del estudiante: ");

    var registrationValue = CalculateRegistrationValue(Credits, CreditCost, StudentStratum);
    var subsidy = CalculateSubsidy(StudentStratum);

    Console.WriteLine($"Costo de la matricula: {registrationValue,20:C2}");
    Console.WriteLine($"Valor del subsidio: {subsidy,20:C2}");


    do
    {
        answer = ConsoleExtension.GetValidOptions("¿Deseas continuar [S]í, [N]o?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));

} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));

Console.WriteLine("Game Over.");

decimal CalculateSubsidy(int StudentStratum)
{
    if (StudentStratum == 1)
    {
        return 200000m;
    }   
    if (StudentStratum == 2)
    {
        return 100000m;
    }
    return 0;
}

decimal CalculateRegistrationValue(int credits, decimal CreditCost, int studentStratum)
{
    decimal value;
    if (credits <= 20)
    {
        value = credits * CreditCost;
    }
    else
    {
        value = 20 * CreditCost + (credits - 20) * CreditCost * 2;
    }
    if (studentStratum == 1)
    {
        return value * 0.2m;
    }
    if (studentStratum == 2)
    {
        return value * 0.5m;
    }
    if (studentStratum == 3)
    {
        return value * 0.7m;
    }

    return value;

}