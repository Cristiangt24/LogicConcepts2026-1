using Shared;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    var a = ConsoleExtension.GetDouble("Digita el valor de a: ");
    var b = ConsoleExtension.GetDouble("Digita el valor de b: ");
    var c = ConsoleExtension.GetDouble("Digita el valor de c: ");
    var badge = Math.Pow(b, 2) - 4 * a * c;
    if (badge < 0)
    {
        Console.WriteLine("La ecuación no tiene soluciones reales.");
    }
    else if (badge == 0)
    {
        var root = -b / (2 * a);
        Console.WriteLine($"x1: {root:N5}");
    }
    else
    {
        var x1 = (-b + Math.Sqrt(badge)) / (2 * a);
        var x2 = (-b - Math.Sqrt(badge)) / (2 * a);
        Console.WriteLine($"x1 = {x1:N5}");
        Console.WriteLine($"x2 = {x2:N5}");
    }
    do
    {
        answer = ConsoleExtension.GetValidOptions("¿Deseas continuar [S]í, [N]o?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));
} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));
Console.WriteLine("Game Over.");