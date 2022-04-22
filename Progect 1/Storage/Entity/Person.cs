namespace Progect_1.Storage.Entity
{

    public class Person
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Pass { get; set; }
        public int Phone_Number { get; set; }
       /* public Person(Guid id, string name, string lastname, string pass, int phone_number)
        {
            Id = id;
            Name = name;
            LastName = lastname;
            Pass = pass;
            Phone_Number = phone_number;
        }*/
    }
}
