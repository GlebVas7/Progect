using Microsoft.EntityFrameworkCore;
using Progect_1.Storage;
using Progect_1.Storage.Entity;

namespace Progect_1.Models
{
    public class CreatorModel : ICreatorModel
    {
        private readonly ExampleContex _dbContext;

        public CreatorModel(ExampleContex dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task deleteCreator(Guid id)
        {
            var entity = await _dbContext.Creators.FirstOrDefaultAsync(x => x.Id == id);

            if(entity != null)
                _dbContext.Remove(entity);

            await _dbContext.SaveChangesAsync();
        }

        public async Task <IList<Creator>> getAllCreator() => await _dbContext.Creators.ToListAsync();

    }
}
