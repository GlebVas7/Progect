using Progect_1.Storage.Entity;


namespace Progect_1.Managers.Persons
{
    public interface IPerson
    {
        ICollection<Person> GetALL();
        void Delete(Guid id);
    }
}
