using AdvancedFeatues.Interface.Implementations;

namespace AdvancedFeatues.Interface;

internal class Program
{
    private static void Main (string[] args)
    {
        var rectangle = new Rectangle();
        rectangle.CalculateArea(10, 20);
        rectangle.DoubleCalculateArea(10, 20);

        var nested = new ImplementingBothAbstractAndInterface.Nested();
        nested.PropertyOfNestedClass = 25;

        //var nested = new ImplementingBothAbstractAndInterface.Nested
        //{
        //    PropertyOfNestedClass = 25
        //};

        var frankoAge = nested.PropertyOfNestedClass;

        Console.WriteLine("This is get: " + frankoAge);

        Console.WriteLine("This is method execution: " + nested.Method());

        // Anonymos Class 

        var franko = new
        {
            Age = nested.Method(),
            Name = "Franko"
        };

        Console.WriteLine($"Name: {franko.Name} and age is {franko.Age}");
    }
}
