using System.ComponentModel.DataAnnotations;

namespace Progect_1.Storage.Entity
{
    public class Drink
    {
        [Key]
        public int Id { get; set; }
        public string? Name_Of_Drink { get; set; }
        public int Liters { get; set; }
        public int Price { get; set; }
        public string?  Link  { get; set; }
    }
}
