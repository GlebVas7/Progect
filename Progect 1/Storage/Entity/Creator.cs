using System.ComponentModel.DataAnnotations;

namespace Progect_1.Storage.Entity
{
    public class Creator
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string  Sex { get; set; }
        public string Link { get; set; }
    }
}
