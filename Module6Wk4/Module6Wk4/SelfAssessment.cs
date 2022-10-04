namespace Module6Wk4;

public class SelfAssessment
{
    public static void Sqrt() //Problem 7
    {
        try
        {
            var num = int.Parse(Console.ReadLine() ?? string.Empty);
            if (num < 0)
            {
                throw new FormatException();
            }

            Console.WriteLine(Math.Sqrt(num));
        }
        catch
        {
            Console.WriteLine("Invalid Number");
        }
        finally
        {
            Console.WriteLine("Good Bye");
        }
    }

    public static void ReadNumber(int start, int end) //Problem 8
    {
        var nums = new int[10];
        try
        {
            for (var i = 0; i < 10; i++)
            {
                var num = int.Parse(Console.ReadLine() ?? string.Empty);
                if (start >= num || num >= end) throw new Exception($"{num} is not between {start} and {end}");
                if (i == 0)
                {
                    nums[0] = num;
                }

                if (nums[i - 1] >= num) throw new Exception($"{num} is not larger than {nums[i - 1]}");
                nums[i] = num;
            }
        }
        catch (FormatException fe)
        {
            Console.WriteLine(fe);
            throw;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}