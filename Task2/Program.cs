namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal[] array = new Animal[]
            {
                new Dog(2, "Goff"),
                new Cat(3, "Pisika"),
                new Dog(1, "Guf"),
                new Cat(4, "kika"),
                new Dog(5, "lesi"),
                new Cat(6, "lilo"),


            };
            foreach (Animal a in array)
            {
                a.Move();
                a.Speak();
                Console.WriteLine(a.ToString());

            }
        }
        public abstract class Animal
        {
            private int _age;
            private string _name;

            public Animal(int age, string name)
            {
                this._age = age;
                this._name = name;
            }
            public abstract void Move();
            public abstract void Speak();
            public override string ToString()
            {
                return "Age" + _age + "Name" + _name;
            }
        }
        public class Dog : Animal
        {
            public Dog(int _age, string _name) : base(_age, _name)
            {
            }
            public override void Move()
            {
                Console.WriteLine("Dog is moving");
            }

            public override void Speak()
            {
                Console.WriteLine("HUm Hum");
            }
        }
        public class Cat : Animal
        {
            public Cat(int age, string name) : base(age, name)
            {
            }
            public override void Move()
            {
               Console.WriteLine("Cat is moving");
            }
            public override void Speak()
            {
                Console.WriteLine("Mjau Mjau");
            }
        }
    }
}


