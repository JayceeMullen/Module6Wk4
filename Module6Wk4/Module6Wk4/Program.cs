namespace Module6Wk4;

internal static class Program
{
	private static void Main()
	{
		Console.WriteLine("Select an operation.\n1) AddValues\n2) SubtractValues\n3) MultiplyValues\n4) DivideValues\n5) RemainderValues\n");
		var userChoice = Console.ReadLine() ?? string.Empty;
		Console.WriteLine("Enter a number.");
		var valueOne = Console.ReadLine() ?? string.Empty;
		Console.WriteLine("Enter another number.");
		var valueTwo = Console.ReadLine() ?? string.Empty;

		switch (userChoice)
		{
			case "1":
				Console.WriteLine($"Result={AddValues(valueOne, valueTwo)}");
				break;
			case "2":
				Console.WriteLine($"Result={SubtractValues(valueOne, valueTwo)}");
				break;
			case "3":
				Console.WriteLine($"Result={MultiplyValues(valueOne, valueTwo)}");
				break;
			case "4":
				Console.WriteLine($"Result={DivideValues(valueOne, valueTwo)}");
				break;
			case "5":
				Console.WriteLine($"Result={RemainderValues(valueOne, valueTwo)}");
				break;
		}
	}

	private static int AddValues(string valueOne, string valueTwo)
	{
		var parsedValueOne = int.Parse(valueOne);
		var parsedValueTwo = int.Parse(valueTwo);
		return parsedValueOne + parsedValueTwo;
	}

	private static int SubtractValues(string valueOne, string valueTwo)
	{
		var parsedValueOne = int.Parse(valueOne);
		var parsedValueTwo = int.Parse(valueTwo);
		return parsedValueOne - parsedValueTwo;
	}

	private static int MultiplyValues(string valueOne, string valueTwo)
	{
		var parsedValueOne = int.Parse(valueOne);
		var parsedValueTwo = int.Parse(valueTwo);
		return parsedValueOne* parsedValueTwo;
	}

	private static int DivideValues(string valueOne, string valueTwo)
	{
		var parsedValueOne = int.Parse(valueOne);
		var parsedValueTwo = int.Parse(valueTwo);
		return parsedValueOne / parsedValueTwo;
	}

	private static int RemainderValues(string valueOne, string valueTwo)
	{
		var parsedValueOne = int.Parse(valueOne);
		var parsedValueTwo = int.Parse(valueTwo);
		return parsedValueOne % parsedValueTwo;
	}
}