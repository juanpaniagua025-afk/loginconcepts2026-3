namespace shared;

public static class ConsoleExtension
{
	public static int GetInt(string message)
	{
		Console.Write(message);
		var numberString = Console.ReadLine();

		if (int.TryParse(numberString, out int numberInt))
		{
			return numberInt;
		}

		Console.WriteLine("Entrada inválida. Se devuelve 0.");
		return 0;
	}

	public static string? GetValidOptions(string message, List<string> options)
	{
		Console.Write(message);
		var answer = Console.ReadLine();

		if (!string.IsNullOrWhiteSpace(answer) &&
			options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)))
		{
			return answer;
		}

		Console.WriteLine("Opción inválida.");
		return null;
	}
}