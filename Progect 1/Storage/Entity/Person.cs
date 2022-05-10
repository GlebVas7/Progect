using System.ComponentModel.DataAnnotations;

namespace Progect_1.Storage.Entity
{

    public class Person
    {
        [Key]
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? LastName { get; set; }
        public string? Pass { get; set; }
        public string? Phone_Number { get; set; }
    }
}
