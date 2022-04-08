namespace Progect_1.Managers.Person
{
    public interface IPersonManager
    {
        Storage.Entity.Person GetPersonById(Guid id);
    }
}
