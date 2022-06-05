using PersonModel.Models;

namespace PersonApi.Brokers.Storages;

public class StorageBroker: IStorageBroker
{
    public IQueryable<Person> SelectAllPersons()
    {
        return new List<Person>
        {
            new Person
            {
                Id = Guid.NewGuid(),
                FirstName = "Mike",
                MiddleName = "Teddy",
                LastName = "Vazovsky",
                Gender = Gender.Male,
                BirthDate = new DateTime(1980, 2, 15),
            },
            new Person
            {
                Id = Guid.NewGuid(),
                FirstName = "Bob",
                MiddleName = "Richard",
                LastName = "Smith",
                Gender = Gender.Male,
                BirthDate = new DateTime(1982, 5, 10),
            },
            new Person
            {
                Id = Guid.NewGuid(),
                FirstName = "Mia",
                MiddleName = "John",
                LastName = "Smith",
                Gender = Gender.Female,
                BirthDate = new DateTime(1985, 7, 14),
            },
        }.AsQueryable();
    }
}