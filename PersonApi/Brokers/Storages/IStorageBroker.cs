using PersonModel.Models;

namespace PersonApi.Brokers.Storages;

public interface IStorageBroker
{
    IQueryable<Person> SelectAllPersons();
}