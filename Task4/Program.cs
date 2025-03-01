﻿namespace Task4
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

            public int _Age;
            public string _name;

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