using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Progect_1.Storage.Entity
{
    public class Order
    {
        [Key]
        public Guid Id { get; set; }
        public string? NameOfFood { get; set; }
        public string? NameOfDrink { get; set; }
        public string? Name { get; set; }
        public string? Lastname { get; set; }
        public string? Adress { get; set; }
    }
}

