using System.Linq;

namespace Advance.Features.Presantation.Async;

internal class Program
{
    static void Main(string[] args)
    {
        var classRoom = new ClassRoom
        {
            Peoples = new List<People>
        {
            new People()
            {
                Name = "Franko",
                Age = 23
            },
            new People()
            {
                Name = "Denisa",
                Age = 29
            },
            new People()
            {
                Name = "Nikolin",
                Age = 24
            },
            new People()
            {
                Name = "Geri",
                Age = 19
            }
        }
        };
        var peoplesBiggerThan22 = classRoom.GetPeoplesBiggerThan(22);
        foreach (var people in peoplesBiggerThan22)
        {
            Console.WriteLine(people.Name);
        }
        
        _ = classRoom.GetPeoplesBiggerThanAsync(22);
        {
            Console.WriteLine("This is after getting people");
            _ = Console.ReadLine();
        }

    }
}

public class ClassRoom
{
    public List<People> Peoples { get; set; }
    public List<People> GetPeoplesBiggerThan(int age)
    {
        return Peoples.Where(x => x.Age > age).ToList();
    }
    //public async Task<List<People>> GetPeoplesBiggerThan22(int age)
    //{               
    //      return await Peoples.Where(x => x.Age > age).ToListAsync();       
    //}

    public async Task<List<People>> GetPeoplesBiggerThanAsync(int age)
    {
        return await Task.Run(async () =>
        {
            await Task.Delay(5000);
            Console.WriteLine("This is going to run late");
            return GetPeoplesBiggerThan(age);
        });

    }
}

public class People
{
    public int Age { get; set; }
    public string Name { get; set; }
}
