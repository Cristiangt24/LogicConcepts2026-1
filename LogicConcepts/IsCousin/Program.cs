using Shared;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    var number = ConsoleExtension.GetInt("Ingresa número: ");
    var isPrime = MyMath.IsPrime(number);
    Console.WriteLine($"El número: {number} {(isPrime ? "SI" : "NO")} es primo.");

    do
{
    answer = ConsoleExtension.GetValidOptions("¿Deseas continuar [S]í, [N]o?: ", options);
} while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));

} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase)) ;

Console.WriteLine("Game Over.");
