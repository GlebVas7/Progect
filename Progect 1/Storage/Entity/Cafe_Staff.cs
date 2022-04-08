namespace Progect_1.Storage.Entity
{
    public class Cafe_Staff
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Profession { get; set; }
        public Cafe_Staff(Guid id, string name, string lastname, string profession)
        {
            Id = id;
            Name = name;
            Lastname = lastname;
            Profession = profession;
        }
    }
}
