using AdvancedFeatues.Interface.Interfaces;

namespace AdvancedFeatues.Interface.Implementations;

internal class Rectangle : IPolygon
{
    // Implement all methods that interface have
    public void CalculateArea (int a, int b)
    {
        var area = a * b;
        Console.WriteLine("Area of Reactangle: " + area);
    }
}
