namespace CustomFilter
{
    public class Employee : IPerson
    {
        public Employee(string position, string name, string lastName, string address, int number)
        {
            Position = position;
            Name = name;
            LastName = lastName;
            Address = address;
            Number = number;
        }
        
        public string Position { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public int Number { get; set; }
    }
}