using RestWithASPNETUdemy.Business;
using RestWithASPNETUdemy.Model;
using System.Collections.Generic;

namespace RestWithASPNETUdemy.Repository
{
    public interface IPersonRepository : IRepository<Person>
    {
        Person Disable(long id);

        List<Person> findByName(string firstName, string secondName);
    }
}
