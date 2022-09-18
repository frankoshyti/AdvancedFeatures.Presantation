namespace IntSquare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            string s = Console.ReadLine();
            try
            {
                int parsed = int.Parse(s);
                if(parsed < 0)
                {
                    throw new ArgumentException();
                }
                Console.WriteLine("Square = " + Math.Sqrt(parsed));
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Invalid Number");
            }
            catch (FormatException e)
            {
                Console.WriteLine("Invalid Number");
            }
            catch (OverflowException exs)
            {
                Console.WriteLine("Invalid Number");
            }
            finally
            {
                Console.WriteLine("Goodbye");
            }
        }
    }
}