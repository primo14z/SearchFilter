using CustomFilter;

internal class Program
{
    private static void Main(string[] args)
    {
        var persons = new List<Person>()
        {
            new Person(){
                Name = "Janez",
                LastName = "Novak",
                Address = "Lj"
            },
            new Person()
            {
                Name = "Miha",
                LastName = "Mihec",
                Address = "Kp"
            }
        };

        System.Console.WriteLine(SearchFilter.Search(persons, "Patrik"));

    }
}