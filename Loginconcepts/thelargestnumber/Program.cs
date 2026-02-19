Console.WriteLine("Ingreso tres números diferentes =>");
Console.Write("Ingrese primer número: ");
var number1String = Console.ReadLine();
var number1Int = int.Parse(number1String!);
Console.Write("Ingrese segundo número: ");
var number2String = Console.ReadLine();
var number2Int = int.Parse(number2String!);
Console.Write("Ingrese tercer número: ");
var number3String = Console.ReadLine();
var number3Int = int.Parse(number3String!);
if (number1Int > number2Int && number1Int > number3Int)
{
	Console.WriteLine($"El número mayor es: {number1Int}");
}
else if (number2Int > number1Int && number2Int > number3Int)
{
	Console.WriteLine($"El número mayor es: {number2Int}");
}
else if (number3Int > number2Int && number3Int > number1Int)
{
	Console.WriteLine($"El número mayor es: {number3Int}");
}
else
{
	Console.WriteLine($"Al menos menos 2 números son iguales.");
}