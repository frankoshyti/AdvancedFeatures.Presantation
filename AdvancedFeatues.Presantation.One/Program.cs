namespace AdvancedFeatues.Presantation.One;

internal class Program
{
    private static void Main (string[] args)
    {
        Console.WriteLine("We have best class ever!");

        // This is a child object created from Child
        var child = new Child();
        child.MethodOne();
        child.Method();
        child.VritualMethod();

        child.HideMethod();

        // This is a 'parent' object created from base
        //var baseObject = new Base(5);
        var baseObject = new Base();
        baseObject.Method();
        //baseObject.GetSomethingFromBase();

        _ = Console.ReadLine();
    }
}

public class Base
{
    //private int Something { get; set; }

    //public Base (int something)
    //{
    //    Something = something;
    //}

    //public int GetSomethingFromBase ()
    //{
    //    return Something;
    //}

    public void Method ()
    {
        Console.WriteLine("This is comming from Base Class!");
    }

    // This will be hiden in Child
    public void HideMethod ()
    {
        Console.WriteLine("Hiden method from Base!");
    }

    // This method will be overriden in child
    public virtual void VritualMethod ()
    {
        Console.WriteLine("This is virutal and is comming from base method");
    }

    // This is abstract method
    //public abstract void AbstractMethod ();
}

public class Child : Base
{
    public void MethodOne ()
    {
        Console.WriteLine("This is comming from child");
    }

    // This is intended to be hide with new keyword
    public new void HideMethod ()
    {
        Console.WriteLine("This is a new method in child");
    }

    public override void VritualMethod ()
    {
        Console.WriteLine("No no i am a child");

        base.VritualMethod();
    }

    //public override void AbstractMethod ()
    //{
    //    throw new NotImplementedException();
    //}
}