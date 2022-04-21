using Progect_1.Storage.Entity;

namespace Progect_1.Models
{
    public interface IGeoDatasModel
    {
        void DeleteGeo(Guid Id);
        GeoDatas AddGeo(GeoDatas geoDatas);
        List<GeoDatas> GetAllGeoDatas();
    }
}
