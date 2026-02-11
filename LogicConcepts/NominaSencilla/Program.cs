using Shared;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{     
    Console.WriteLine("Bienvenido al sistema de nómina sencilla");
    var Usuario = ConsoleExtension.GetString("Ingrese el nombre del empleado: ");
    var HorasTrabajadas = ConsoleExtension.GetDecimal("Ingrese el numero de horas trabajadas del empleado: ");
    var ValorHora = ConsoleExtension.GetDecimal("Ingrese el valor por hora del empleado: ");
    var Salario = ConsoleExtension.GetDecimal("Ingrese el salario minimo del mes ");
    var SalarioTotal = HorasTrabajadas * ValorHora;

    if (SalarioTotal > Salario)
    {
        Console.WriteLine($"Empleado:  {Usuario}");
        Console.WriteLine($"Salario: {SalarioTotal}");
        Console.WriteLine("El empleado Gana mas del salario Minimio");
    }
    else
    {
        Console.WriteLine($"El Nombre del empleado es: {Usuario}");
    }
    do
    {
        answer = ConsoleExtension.GetValidOptions("¿Deseas continuar [S]í, [N]o?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));

} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));

Console.WriteLine("Game Over.");