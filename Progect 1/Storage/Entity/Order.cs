using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Progect_1.Storage.Entity
{
    public class Order
    {
        [Key]
        public Guid Id { get; set; }
        public string NameOfFood { get; set; }
        public string NameOfDrink { get; set; }
        public int Price_Of_Order { get; set; }
        [Required]
        public Guid PersonId { get; set; }

        [ForeignKey(nameof (PersonId))]
        public virtual Person Person { get; set; }
    }
}
