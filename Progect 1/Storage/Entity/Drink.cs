using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Progect_1.Storage.Entity
{
    public class Drink
    {
        [Key]
        public int Id { get; set; }
        public string NameOfDrink { get; set; }

    }
}
