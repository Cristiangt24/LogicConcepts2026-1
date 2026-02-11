using Shared;
using static System.Runtime.InteropServices.JavaScript.JSType;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{     
    Console.WriteLine("Bienvenido al sistema de nómina sencilla");
    var User = ConsoleExtension.GetString("Ingrese el nombre del empleado: ");
    var HoursWorked = ConsoleExtension.GetDecimal("Ingrese el numero de horas trabajadas del empleado: ");
    var hourlyrate = ConsoleExtension.GetDecimal("Ingrese el valor por hora del empleado: ");
    var salary = ConsoleExtension.GetDecimal("Ingrese el salario minimo del mes ");
    var SalaryTotal = HoursWorked * hourlyrate;

    if (SalaryTotal > salary)
    {
        Console.WriteLine($"Empleado:  {User}");
        Console.WriteLine($"Salario: {SalaryTotal}");
        Console.WriteLine("El empleado Gana mas del salario Minimio");
    }
    else
    {
        Console.WriteLine($"El Nombre del empleado es: {User}");
    }
    do
    {
        answer = ConsoleExtension.GetValidOptions("¿Deseas continuar [S]í, [N]o?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));

} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));

Console.WriteLine("Game Over.");