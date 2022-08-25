using ExtensionMethods;

namespace CustomFilter;
public static class Program
{
    private static void Main(string[] args)
    {
        var persons = new List<object>()
        {
            new Employe(){
                Name = "Bepi",
                LastName = "Novak",
                Address = "Lj",
                Number = 123
            },
            new Employe(){
                Name = "Juca",
                LastName = "Novak",
                Address = "Lj",
                Number = 456
            },
            new ExternalEmploye()
            {
                Name = "Miha",
                LastName = "Mihec",
                Address = "Kp"
            },
            new ExternalEmploye()
            {
                Name = "Janez",
                LastName = "Mihec",
                Address = "Kp"
            }
        };

        foreach (var item in SearchFilter.Search(persons, 456))
        {
            Console.WriteLine((item as IPerson).Name);
        }
    }
}