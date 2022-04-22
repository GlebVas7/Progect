using Progect_1.Models;

namespace Progect_1.Managers.Person
{
    public class PersonManager : IPersonManager
    {
        private IPersonModel personModel;

        public PersonManager()
        {
        }

        public PersonManager(IPersonModel _model)
        {
            personModel = _model;
        }

        public Storage.Entity.Person GetAll()
        {
            throw new NotImplementedException();
        }

        public Storage.Entity.Person GetPersonById(Guid id)
        {
            return personModel.GetPersonById(id);
        }
    }
}
