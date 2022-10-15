using System.IO;
namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter file path");
            string path = Console.ReadLine();
            try
            {
                string content = System.IO.File.ReadAllText(path);
                Console.WriteLine(content);
                File.AppendAllText(path, "Franko" + Environment.NewLine);
                
            }
            catch (DirectoryNotFoundException e)
            {

                Console.WriteLine("Directory Not Found");
                // Console.WriteLine(e.Message);
            }
            catch (PathTooLongException f)
            {
                Console.WriteLine("Path entered is to long");
                //  Console.WriteLine(f.Message);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Path file not provided");
                //  Console.WriteLine(ex.Message);
            }
            catch (FileNotFoundException exe)
            {
                Console.WriteLine("File entered not found");
                //  Console.WriteLine(exe.Message);
            }
            catch (Exception exes)
            {
                Console.WriteLine(exes.Message);
            }
            finally
            {
                Console.WriteLine("Goodbye");
            }
            Console.ReadKey();
        }
    }
}