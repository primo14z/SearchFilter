namespace CustomFilter
{
    public class ExternalEmployee : IPerson
    {
        public ExternalEmployee(string name, string lastName, string address)
        {
            Name = name;
            LastName = lastName;
            Address = address;
        }

        public string Name { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
    }
}