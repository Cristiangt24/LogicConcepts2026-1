using Shared;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    var terms = ConsoleExtension.GetInt("Cuantos términos desea: ");
    var x = ConsoleExtension.GetDouble("Digita el valor de x: ");
    var taylor = Taylor(x, terms);
    Console.WriteLine($"f({x}) = {taylor:N6}");
    double Taylor(double x, int terms)
    {
        double sum = 0;
        for (int i = 0; i < terms; i++)
        {
            sum += Math.Pow(x, i) / MyMath.Factorial(i);
        }
        return sum;
    }

    do
    {
        answer = ConsoleExtension.GetValidOptions("¿Deseas continuar [S]í, [N]o?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));
} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));
Console.WriteLine("Game Over.");


