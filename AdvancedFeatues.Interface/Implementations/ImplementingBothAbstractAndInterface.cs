namespace AdvancedFeatues.Interface.Implementations;

internal class ImplementingBothAbstractAndInterface : NotImplementingInterface
{
    public override void AnotherMethod()
    {
        Console.WriteLine("Just another method!");
    }

    public override void CalculateArea(int a, int b)
    {
        Console.WriteLine("Implementation of interface method!");
    }

    internal class Nested
    {
        public int PropertyOfNestedClass { get; set; }
    }
}