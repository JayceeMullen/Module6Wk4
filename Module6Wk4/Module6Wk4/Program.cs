namespace Module6Wk4;

internal static class Program
{
	private static void Main()
	{
		Console.WriteLine("Select an operation.\n1) AddValues\n2) SubtractValues\n3) MultiplyValues\n" +
		                  "4) DivideValues\n5) RemainderValues\n");
		int valueOne = 0, valueTwo = 0;
		string? userChoice = null;
		try
		{
			userChoice = Console.ReadLine() ?? throw new InvalidOperationException();
			Console.WriteLine("Enter a number.");
			valueOne = int.Parse(Console.ReadLine() ?? string.Empty);
			Console.WriteLine("Enter another number.");
			valueTwo = int.Parse(Console.ReadLine() ?? string.Empty);
		}
		catch (FormatException)
		{
			Console.WriteLine("That is not a number");
		}
		catch (OverflowException)
		{
			Console.WriteLine("That number is out of range for Int32");
		}
		catch (InvalidOperationException)
		{
			Console.WriteLine("That is not a valid selection");
		}
		catch (Exception e)
		{
			Console.WriteLine(e.StackTrace);
            throw;
        }

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

	private static int AddValues(int valueOne, int valueTwo)
	{
		return valueOne + valueTwo;
	}

	private static int SubtractValues(int valueOne, int valueTwo)
	{
		return valueOne - valueTwo;
	}

	private static int MultiplyValues(int valueOne, int valueTwo)
	{
		return valueOne * valueTwo;
	}

	private static int DivideValues(int valueOne, int valueTwo)
	{
		return valueOne / valueTwo;
	}

	private static int RemainderValues(int valueOne, int valueTwo)
	{
		return valueOne % valueTwo;
	}
}