using AdvancedFeatues.Interface.Implementations;

namespace AdvancedFeatues.Interface;

internal class Program
{
    private static void Main (string[] args)
    {
        var rectangle = new Rectangle();
        rectangle.CalculateArea(10, 20);
    }
}
