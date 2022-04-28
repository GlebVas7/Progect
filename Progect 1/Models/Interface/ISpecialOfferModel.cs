using Progect_1.Storage.Entity;

namespace Progect_1.Models
{
    public interface ISpecialOfferModel
    {
        void DeleteSpecialOffer(Guid Id);
        SpecialOffer AddNewDish(SpecialOffer nameOfFood);
        SpecialOffer AddNewDrink(SpecialOffer nameOfDrink);
        SpecialOffer ChangeDate(SpecialOffer DataOfSpecialOffer);
        SpecialOffer ChangePrice(SpecialOffer Price);


    }
}
