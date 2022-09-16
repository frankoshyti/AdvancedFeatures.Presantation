namespace AdvancedFeatures.Exceptions;

internal class Program
{
    private static void Main (string[] args)
    {
        var s = Console.ReadLine();

        try
        {
            _ = int.Parse(s);
            Console.WriteLine("You entered valid number");

            //_ = Sqrt(-1);
            //Console.WriteLine("This is after sqrt!");
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid integer number!");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Number is to big for int");
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.Error.WriteLine("Error: " + ex.Message);
            throw;
        }
    }

    public static double Sqrt (double value)
    {
        if (value < 0)
        {
            throw new ArgumentOutOfRangeException("Sqrt for negative numbers is undefined");
        }

        return Math.Sqrt(value);
    }
}