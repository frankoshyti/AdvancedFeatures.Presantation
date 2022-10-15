namespace List_of_students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new Student()
                {
                    Name = "Franko",
                    Surname = "Shyti",
                    Grades = 10,
                },
                new Student()
                {
                    Name = "Denisa",
                    Surname = "Shyti",
                    Grades = 8,
                },
                new Student()
                {
                    Name = "john",
                    Surname = "Doe",
                    Grades = 4,
                },
                new Student()
                {
                    Name = "Jack",
                    Surname = "Reacher",
                    Grades = 7,
                }
            };
            foreach(var student in students.Where(x => !x.HavePassed()))
            {
                Console.WriteLine($"{student.Name}, your grade is {student.Grades}, and");
            }
            Console.WriteLine();
            Console.WriteLine($"Exellent");
            foreach (var student in students.Where());
        }
    }
    class Student : IStudents 
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Grades { get; set; }
        public bool HavePassed()
        {
            if(Grades > 4)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool IsExellent()
        {
            if(Grades == 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
interface IStudents
{
    bool HavePassed();
    bool IsExellent();
}