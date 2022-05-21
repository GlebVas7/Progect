using Microsoft.EntityFrameworkCore;
using Progect_1.Models.Interface;
using Progect_1.Storage;
using Progect_1.Storage.Entity;

namespace Progect_1.Models.Realization
{
    public class MenuModel : IMenuModel
    {
        private ExampleContex _dbContext;
        public MenuModel(ExampleContex exampleContex)
        {
            _dbContext = exampleContex;
        }
        public async Task AddData(Menu menu)
        {
            menu.Id = new int();
            if (menu.Id != null)
            {
                _dbContext.Add(menu);
                await _dbContext.SaveChangesAsync();
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        public async Task DeleteData(int id)
        {
            var entity = _dbContext.Menus.FirstOrDefault(x => x.Id == id);
            if (entity != null)
                _dbContext.Menus.Remove(entity);
            await _dbContext.SaveChangesAsync();
        }
        /*public int FindFood(int id)
        {
            foreach (var menu in _dbContext.Menus)
                if (menu.Id == id)
                   return menu.Price;
            return 0;
        }
        public int FindDrink(int id)
        {
            foreach (var menu in _dbContext.Menus)
                if (menu.Id == id)
                    return menu.Price;
            return 0;
        }*/
        public async Task<IList<Menu>> OutputData() => await _dbContext.Menus.ToListAsync();
    }
}
