using IoCExample.Repository;

namespace IoCExample.Bll
{
    public class PersonBll
    {
        private readonly IPersonRepository _personRepository;

        public PersonBll(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }
    }
}