namespace AdvancedFeatues.Interface.Implementations;

internal class ImplementingBothAbstractAndInterface : NotImplementingInterface
{
    public override void AnotherMethod ()
    {
        Console.WriteLine("Just another method!");
    }

    public override void CalculateArea (int a, int b)
    {
        Console.WriteLine("Implementation of interface method!");
    }

    public override void DoubleCalculateArea (int a, int b)
    {
        Console.WriteLine("Implementation of interface and abstract!");
    }

    internal class Nested
    {
        public int PropertyOfNestedClass { get; set; }

        // Other methods
        public int Method ()
        {
            return PropertyOfNestedClass;
        }
    }
}

internal class ImplementingBothAbstractAndInterface2 : ImplementingBothAbstractAndInterface
{
    public override void DoubleCalculateArea (int a, int b)
    {
        base.DoubleCalculateArea(a, b);
    }
}
