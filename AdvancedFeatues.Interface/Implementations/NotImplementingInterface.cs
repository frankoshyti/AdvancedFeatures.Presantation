using AdvancedFeatues.Interface.Interfaces;

namespace AdvancedFeatues.Interface.Implementations;

internal abstract class NotImplementingInterface : IPolygon
{
    public abstract void AnotherMethod ();

    public abstract void CalculateArea (int a, int b);

    // Its not implemented, will obligate child
    public abstract void DoubleCalculateArea (int a, int b);

    // Implemented method
    //public void DoubleCalculateArea (int a, int b)
    //{
    //    Console.WriteLine("Something");
    //}
}
