using Shared;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{ 
    var number = ConsoleExtension.GetInt("Cuantos primos desea: ");

    if (number > 0)
    {
        int count = 0;
        int candidate = 2;
        int sum = 0;

        // Mostramos el 1 primero (aunque no es primo)
        Console.Write("1 ");
        sum += 1;

        while (count < number - 1)
        {
            bool isPrime = true;

            for (int i = 2; i <= Math.Sqrt(candidate); i++)
            {
                if (candidate % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)
            {
                Console.Write($"{candidate} ");
                sum += candidate;
                count++;
            }

            candidate++;
        }
        double promedio = (double)sum / number;

        Console.WriteLine($"\nLa Suma es: {sum}");
        Console.WriteLine($"El Promedio es: {promedio:N0}");
    }

    do
        {
            answer = ConsoleExtension.GetValidOptions("¿Deseas continuar [S]í, [N]o?: ", options);
        } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));

    } while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));

    Console.WriteLine("Game Over.");
    