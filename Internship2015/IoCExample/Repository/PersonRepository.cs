using System.Collections.Generic;

namespace IoCExample.Repository
{
    public class PersonRepository : IPersonRepository
    {
        public List<Person> GetPeople()
        {
            var list = new List<Person>
            {
                new Person("Rami", "Atieyeh"),
                new Person("Patricia", "Atieyeh"),
                new Person("Shaza", "Zliek")
            };

            return list;
        } 
    }
}