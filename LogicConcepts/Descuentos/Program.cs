using Shared;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{ 
    Console.WriteLine("Bienvenido al sistema de Descuentos");
    int Despokt = ConsoleExtension.GetInt("Numero de escritorios a comprar: ");
    var total = Despokt * 650000;

    if (Despokt <= 5)
    {
        Console.WriteLine($"El numero de escritorios es: {Despokt}");
        Console.WriteLine($"El descuento es del 10% y el total a pagar es: {Despokt * 650000 - (total* 0.90)}");
    }
        if (Despokt >= 5 && Despokt <=10)
        {
        Console.WriteLine($"El numero de escritorios es: {Despokt}");
        Console.WriteLine($"El descuento es del 20% y el total a pagar es: {Despokt * 650000 - (total* 0.80)}");
        }
            if (Despokt >= 10)
            {
            Console.WriteLine($"El numero de escritorios es: {Despokt}");
            Console.WriteLine($"El descuento es del 40% y el total a pagar es: {Despokt * 650000 - (total * 0.60)}");
            }


    do
    {
        answer = ConsoleExtension.GetValidOptions("¿Deseas continuar [S]í, [N]o?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));

} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));

Console.WriteLine("Game Over.");