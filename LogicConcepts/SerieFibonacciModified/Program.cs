using Shared;

var answer = string.Empty;
var Options = new List<string> { "s", "n" };

do
{
    int termins = ConsoleExtension.GetInt("Digita el número de Terminos:");

    if (termins > 0)
    {
        int a = 0, b = 1, c = 2, next;
        int sum = 0;

        for (int i = 0; i < termins; i++)
        {
            if (i == 0)
            {
                Console.Write($"{a} ");
                sum += a;
            }
            else if (i == 1)
            {
                Console.Write($"{b} ");
                sum += b;
            }
            else if (i == 2)
            {
                Console.Write($"{c} ");
                sum += c;
            }
            else
            {
                next = a + b + c;
                Console.Write($"{next} ");
                sum += next;

                a = b;
                b = c;
                c = next;
            }
        }

        Console.WriteLine($"\nLa sumatoria es: {sum}");
    }

    do
    {
        answer = ConsoleExtension.GetValidOptions("¿Deseas continuar [S]í, [N]o?: ", Options);
    } while (!Options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));
} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));
Console.WriteLine("Game Over.");