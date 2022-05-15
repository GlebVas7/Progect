using Progect_1.Storage.Entity;

namespace Progect_1.Models
{
    public interface IGeoDatasModel
    {
        Task DeleteGeo(Guid Id);
        Task AddGeo(GeoDatas geoDatas);
        Task <IList<GeoDatas>> GetAllGeoDatas();
    }
}
