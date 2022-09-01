using ExtensionMethods;

namespace CustomFilter;
public static class Program
{
    private static void Main(string[] args)
    {
        var persons = new List<IPerson>()
        {
            new Employee("CTO", "Bepi", "Novak", "Lj", 123),
            new Employee("CEO", "Juca", "Novak", "Lj", 456),
            new ExternalEmployee("Miha", "Mihec", "Kp"),
            new ExternalEmployee("Janez", "Mihec", "Kp")
        };

        foreach (var item in persons.Search("Mi"))
        {
            Console.WriteLine(item?.Name);
        }
    }
}