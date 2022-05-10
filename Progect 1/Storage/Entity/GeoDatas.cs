using System.ComponentModel.DataAnnotations;

namespace Progect_1.Storage.Entity
{
    public class GeoDatas
    {
        [Key]
        public Guid Id { get; set; }
        public string? City { get; set; }
        public string? Street { get; set; }
        public int HouseNumber { get; set; }
    }
}
