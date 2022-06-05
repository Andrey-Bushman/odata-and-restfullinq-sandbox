using PersonModel.Models;

namespace PersonApi.Services;

public interface IPersonService
{
    public IQueryable<Person> RetrieveAllPersons();
}