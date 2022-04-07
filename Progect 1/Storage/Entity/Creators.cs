namespace Progect_1.Storage.Entity
{
    public class Creators
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public int Sex { get; set; }
        public string Link { get; set; }
        public Creators(Guid id, string name, string lastname, int sex, string link)
        {
            Id = id;
            Name = name;
            Lastname = lastname;
            Sex = sex;
            Link = link;
        }
    }
}
