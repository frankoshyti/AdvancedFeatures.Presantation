using System.Runtime.Serialization;

namespace AdvancedFeatures.Exceptions;

internal class Program
{
    private static void Main (string[] args)
    {
        Console.Write("Please enter a number: ");
        var s = Console.ReadLine();

        try
        {
            _ = int.Parse(s!);
            Console.WriteLine("You entered valid number");

            _ = Sqrt(-1);
            Console.WriteLine("This is after sqrt!");
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
        }
        catch
        {
            Console.WriteLine("Exception");

            //throw;

            //throw new NewException("New Exception");
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

public class NewException : FormatException
{
    public NewException (string? message) : base(message)
    {
        Console.WriteLine(message);
        base.ToString();
    }

    public NewException (string? message, Exception? innerException) : base(message, innerException)
    {
    }

    protected NewException (SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }

    public override Exception GetBaseException ()
    {
        return base.GetBaseException();
    }
}