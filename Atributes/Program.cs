namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------integers-------------");
            //instatiate generic with integer
            var intobj = new TestClass<int>();
            //adding int values into collection
            intobj.Add(1);
            intobj.Add(2);
            intobj.Add(3);
            intobj.Add(4);
            intobj.Add(5);
            //what happen if intobj.add(6)
            //displaying values
            for(var i = 0; i < 5; i++)
            {
                Console.WriteLine(intobj[i]); //no unboxing
            }
            _ = Console.ReadKey();
            Console.WriteLine("--------------Strings-------------");
            //instatiate generic with string
            var stringobj = new TestClass<string>();
            //adding string values into collection
            stringobj.Add("One");
            stringobj.Add("Two");
            stringobj.Add("Three");
            stringobj.Add("Four");
            stringobj.Add("Five");
            //displaying vaues
            for(var i = 0; i < 5; i++)
            {
                Console.WriteLine(stringobj[i]);  //No unboxing
            }
            Console.ReadKey();
            Console.WriteLine("---------------------Peoples-------------------");
            var peoples = new TestClass<People>();
            var franko = new People();
            var denisa = new People();
            peoples.Add(new People
            {
                Age = 22,
                Name = "Franko",
                Surname = "Shyti"
            });
            

            peoples.Add(new People
            {
                Age = 29,
                Name = "Denisa",
                Surname = "Shyti"
            });
            
            peoples.Add(new People
            {
                Age = 57,
                Name = "John",
                Surname = "Doe"
            }); 
            peoples.Add(new People
            {
                Age = 25,
                Name = "Avjol",
                Surname = "Sakaj"
            }); 
            peoples.Add(new People
            {
                Age = 27,
                Name = "Armina",
                Surname = "Gjoka"
            });
            for(var i = 0; i < 5; i++)
            {
                var people = peoples[i];
                Console.WriteLine($"{people.Name} {people.Surname} {people.Age}");
            }
            
        }
        public class TestClass<T>
        {
            private readonly T[] obj = new T[5];
            private int count = 0;
            //adding items
            public void Add(T item)
            {
                if (count + 1 < 6)
                {
                    obj[count] = item;
                }
                count++;
            }
            //indexer for foreach statement iteration
            public T this[int index]
            {
                get => obj[index];
                set => obj[index] = value;
            }
        }
        public class People
        {
            public int Age { get; set; }
            public string Name { get; set; }
            public string Surname { get; set; }
        }
    }
}