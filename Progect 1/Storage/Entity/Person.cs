namespace Progect_1.Storage.Entity
{
    public class Person
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string pass { get; set; }
        public Person(Guid id, string name, string lastname, string pass)
        {
            Id = id;
            Name = name;
            LastName = lastname;
            pass = pass;
        }
    }
}
