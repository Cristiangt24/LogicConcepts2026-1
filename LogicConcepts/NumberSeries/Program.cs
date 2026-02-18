using Shared;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    var Numbers = ConsoleExtension.GetInt("Cuantos números desea: ");
    int suma= 0;
    int i = 1;
    while (i <= Numbers)
    {
        Console.Write($"{i}\t");
        suma += i;
        i++;
    }
    var average = suma / Numbers;
    Console.WriteLine();
    Console.WriteLine($"La suma es: {suma,20:N0}");
    Console.WriteLine($"El promedio es: {average,20:N0}");

    do
    {
        answer = ConsoleExtension.GetValidOptions("¿Deseas continuar [S]í, [N]o?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));
} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));

Console.WriteLine("Game Over.");