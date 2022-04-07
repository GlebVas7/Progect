namespace Progect_1.Storage.Entity
{
    public class GeoDatas
    {
        public Guid Id { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int HouseNumber { get; set; }
        public GeoDatas(Guid id, string city, string street, int housenumber)
        {
            Id = id;
            City = city;
            Street = street;
            HouseNumber = housenumber;
        }

    }
}
