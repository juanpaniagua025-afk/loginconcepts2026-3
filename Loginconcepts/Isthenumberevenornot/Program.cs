using shared;

var numberString  = string.Empty;

do
{
	var number = ConsoleExtension.GetInt
	if (number % 2 == 0)
	{
		Console.WriteLine($"El número {number}, es impar.");
	}
	else
	{
		Console.WriteLine($"El número {number}, es par.");
	}

} while (true);

console.WriteLine("Game Over.");