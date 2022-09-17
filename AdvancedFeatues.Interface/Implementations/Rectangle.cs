using AdvancedFeatues.Interface.Interfaces;
using System.Runtime.Serialization;

namespace AdvancedFeatues.Interface.Implementations;

internal class Rectangle : Parent, IPolygon, ISerializable
{
    // Implement all methods that interface have
    public void CalculateArea (int a, int b)
    {
        var area = a * b;
        Console.WriteLine("Area of Reactangle: " + area);
    }

    public void DoubleCalculateArea (int a, int b)
    {
        var area = 2 * a * b;
        Console.WriteLine("Double Area of Reactangle: " + area);
    }

    public void GetObjectData (SerializationInfo info, StreamingContext context)
    {
        throw new NotImplementedException("I havent implemented this!");
    }

    public override void Something ()
    {
        throw new NotImplementedException();
    }
}

public abstract class Parent
{
    public abstract void Something ();
}
