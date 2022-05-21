using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Progect_1.Storage.Entity
{
    public class Ingredient
    {
        [Key]
        [ForeignKey("Menu")]
        public int Id { get; set; }
        public string? IndredientForFood { get; set; }
        public Menu Menu { get; set; }
    }
}
