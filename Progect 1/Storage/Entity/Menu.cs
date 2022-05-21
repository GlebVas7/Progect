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
        public int Price { get; set; }
        public string? Link { get; set; }
        public Ingredient Ingredient { get; set; }
    }
}
