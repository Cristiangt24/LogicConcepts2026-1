using Shared;

var answer = string.Empty;
var Options = new List<string> { "s", "n" };

do
{
    int termins = ConsoleExtension.GetInt("Digita el número de Terminos:");
    
    if ( termins > 0 )
    {
        int a = 0, b = 1, c;
        int sum = 0;
        for (int i = 0; i < termins; i++)
        {
            Console.Write($"{a} ");
            sum += a;
            c = a + b;
            a = b;
            b = c;
        }
        Console.WriteLine($"\nLa Suma es: {sum}");

    }
    else
    {
        Console.WriteLine("El número de términos debe ser mayor que cero.");
}
    do
    {
        answer = ConsoleExtension.GetValidOptions("¿Deseas continuar [S]í, [N]o?: ", Options);
    } while (!Options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));
} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));
Console.WriteLine("Game Over.");