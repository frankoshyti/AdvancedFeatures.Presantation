namespace TASK4.Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal[] array = new Animal[]
               {
            new Dog(1, "Goff"),
            new Cat(2, "pisika"),
            new Dog(2, "Lesi"),
            new Cat(1, "bob"),
            new Dog(3, "bubi"),
            new Cat(4, "Nana"),

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

            private int _Age;
            private string _name;

            public Animal(int age, string name)
            {
                this._Age = age;
                this._name = name;
            }

            public abstract void Speak();
            public abstract void Move();

            public override string ToString()
            {
                return "Age: " + _Age + " name: " + _name;
            }
        }
        public class Dog : Animal
        {
            public Dog(int age, string name) : base(age, name)
            {
            }

            public override void Move()
            {
                Console.WriteLine("Qeni po ecen");
            }

            public override void Speak()
            {
                Console.WriteLine("humm");
            }
        }
        public class Cat : Animal
        {
            public Cat(int age, string name) : base(age, name)
            {
            }

            public override void Move()
            {
                Console.WriteLine("Macja po ecen");
            }

            public override void Speak()
            {
                Console.WriteLine("Mjauuu");
            }
        }
    }
}