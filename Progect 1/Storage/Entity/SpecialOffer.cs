using System.ComponentModel.DataAnnotations;

namespace Progect_1.Storage.Entity
{
    public class SpecialOffer
    {
        [Key]
        public Guid Id { get; set; }
        public string NameOfFood { get; set; }
        public string NameOfDrink { get; set; }
        public int Price { get; set; }
        public int Data_Of_Special_Offer { get; set; }
    }
}
