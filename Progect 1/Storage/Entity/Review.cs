using System.ComponentModel.DataAnnotations;

namespace Progect_1.Storage.Entity
{
    public class Review
    {
        [Key]
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Lastname { get; set; }
        public string? Reviews { get; set; }
    }
}
