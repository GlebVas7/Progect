using Progect_1.Storage;
using Progect_1.Storage.Entity;

namespace Progect_1.Models
{
    public class GeoDatasModel : IGeoDatasModel
    {
        private ExampleContex _dbContext;
        public GeoDatasModel(ExampleContex exampleContex)
        {
            _dbContext = exampleContex;
        }
        public GeoDatas AddGeo(GeoDatas geoDatas)
        {
            if (geoDatas.Id != null || geoDatas.Id != null)
            {
                _dbContext.Add(geoDatas);
            }
            else
            {
                throw new NotImplementedException();
            }
            return geoDatas;
        }

        public void DeleteGeo(Guid id)
        {
            var entity = _dbContext.geoDatas.FirstOrDefault(x => x.Id == id);
            if (entity != null)
                _dbContext.geoDatas.Remove(entity);
            _dbContext.SaveChanges();
        }

        public List<GeoDatas> GetAllGeoDatas()
        {
            throw new NotImplementedException();
        }
    }
}
