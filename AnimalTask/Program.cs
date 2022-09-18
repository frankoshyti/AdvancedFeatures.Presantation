namespace AnimalTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal[] array = new Animal[]
                    {
            new Dog(15, "Goff"),
            new Cat(5, "pisika"),
            new Dog(22, "Lesi"),
            new Cat(11, "bob"),
            new Dog(13, "bubi"),
            new Cat(20, "Nana"),

                    };

            foreach (Animal a in array)
            {
                a.Move();
                a.Speak();
                Console.WriteLine(a.ToString());
            }

            Console.ReadKey();

        }
        public abstract class Animal
        {
            public int _weight;
            public string _name;

            public Animal(int weight, string name)
            {
                this._weight = weight;
                this._name = name;
            }

            public abstract void Speak();
            public abstract void Move();

            public override string ToString()
            {
                return "Weight: " + _weight + " name: " + _name;
            }
        }
        public class Dog : Animal
        {
            public Dog(int weight, string name) : base(weight, name)
            {
            }

            public override void Move()
            {
                Console.WriteLine("Dog is moving");
            }

            public override void Speak()
            {
                Console.WriteLine("humm");
            }
        }
        public class Cat : Animal
        {
            public Cat(int weight, string name) : base(weight, name)
            {
            }

            public override void Move()
            {
                Console.WriteLine("Cat is moving");
            }

            public override void Speak()
            {
                Console.WriteLine("Mjauuu");
            }
        }
    }
}

