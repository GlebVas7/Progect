using Progect_1.Storage.Entity;

namespace Progect_1.Managers.MenuOfPage
{
    public interface IMenu
    {
        ICollection<Menu> GetALL();
        void Delete(Guid id);
    }
}
