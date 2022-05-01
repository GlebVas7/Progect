using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Progect_1.Storage.Entity
{
    public class Review
    {
        [Key]
        public Guid Id { get; set; }
        public string Reviews { get; set; }
        [Required]
        public Guid PersonId { get; set; }

        [ForeignKey(nameof(PersonId))]
        public virtual Person Person { get; set; }
    }
}