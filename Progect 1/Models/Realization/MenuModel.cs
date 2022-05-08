using Microsoft.EntityFrameworkCore;
using Progect_1.Models.Interface;
using Progect_1.Storage;
using Progect_1.Storage.Entity;

namespace Progect_1.Models.Realization
{
    public class MenuModel : IMenuModel
    {
        public Task AddData(Menu menu)
        {
            throw new NotImplementedException();
        }

        public Task DeleteData(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IList<Menu>> OutputData()
        {
            throw new NotImplementedException();
        }
    }
}
