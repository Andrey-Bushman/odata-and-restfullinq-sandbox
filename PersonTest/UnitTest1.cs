using System;
using System.ComponentModel.DataAnnotations;
using PersonModel.Models;
using Xunit;
using RESTFulLinq;
using RESTFulLinq.Clients;
using RESTFulSense.Clients;

namespace PersonTest;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Func<LinQueryable<Person>> getAllPersons = () =>
            new LinQueryable<Person>
            {
                Client = new RESTFulApiClient
                {
                    BaseAddress = new Uri("http://localhost:7271")
                },
                RelativeUrl = "api/Persons/ByLinq"
            };

        // It works in Swagger UI, but doesn't work in C# code. error CS1955: Non-invocable member 'Convert' cannot be used like a method.
        // var persons = getAllPersons().Where(n => (int) n.Gender == 1).ToListAsync<Person>().Result;
        
        // It works fine in Swagger UI and C# code.
        var persons = getAllPersons().Where(n => n.FirstName == "Mia").ToListAsync<Person>().Result;
        Assert.Equal(1,persons.Count);
    }
}