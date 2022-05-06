using Progect_1.Storage.Entity;

namespace Progect_1.Models
{
    public interface IGeoDatasModel
    {
        Task DeleteGeo(int Id);
        Task AddGeo(string geoDatas);
        Task <IList<GeoDatas>> GetAllGeoDatas();
    }
}
