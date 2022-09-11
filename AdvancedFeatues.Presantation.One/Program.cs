namespace AdvancedFeatues.Presantation.One;

internal class Program
{
    private static void Main (string[] args)
    {
        Console.WriteLine("We have best class ever!");

        var child = new Child();
        child.MethodOne();
        child.Method();

        _ = Console.ReadLine();
    }
}




public class Base
{
    internal void Method ()
    {
        Console.WriteLine("This is comming from Base Class!");
    }
}

public class Child : Base
{
    public void MethodOne ()
    {
        Console.WriteLine("This is comming from child");
    }
}