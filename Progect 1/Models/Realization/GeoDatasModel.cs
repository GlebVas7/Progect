using Microsoft.EntityFrameworkCore;
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
        public async Task AddGeo(GeoDatas geoDatas)
        {
            geoDatas.Id = Guid.NewGuid();
            if (geoDatas.Id != null || geoDatas.Id != null)
            {
                _dbContext.Add(geoDatas);
                await _dbContext.SaveChangesAsync();
            }
            else
            {
                throw new NotImplementedException();
            }
            
        }

        public async Task DeleteGeo(Guid id)
        {
            var entity = _dbContext.geoDatas.FirstOrDefault(x => x.Id == id);
            if (entity != null)
                _dbContext.geoDatas.Remove(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IList<GeoDatas>> GetAllGeoDatas() => await _dbContext.geoDatas.ToListAsync();
       
    }
}
