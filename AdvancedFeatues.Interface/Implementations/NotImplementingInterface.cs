using AdvancedFeatues.Interface.Interfaces;

namespace AdvancedFeatues.Interface.Implementations;

internal abstract class NotImplementingInterface : IPolygon
{
    public abstract void AnotherMethod();

    public abstract void CalculateArea(int a, int b);
}
