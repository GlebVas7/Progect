using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Progect_1.Storage.Entity
{
    public class Menu
    {
        [Key]
        public int Id { get; set; }
        public string? NameOfFood { get; set; }
        public int Grams { get; set; }
        public int Liters { get; set; }
        public int Price { get; set; }
    }
}
