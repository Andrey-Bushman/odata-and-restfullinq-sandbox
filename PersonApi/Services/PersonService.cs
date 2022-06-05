using PersonApi.Brokers.Storages;
using PersonModel.Models;

namespace PersonApi.Services;

public class PersonService: IPersonService
{
    private IStorageBroker _storageBroker;

    public PersonService(IStorageBroker storageBroker) => _storageBroker = storageBroker;
    
    public IQueryable<Person> RetrieveAllPersons()
    {
        return _storageBroker.SelectAllPersons();
    }
}