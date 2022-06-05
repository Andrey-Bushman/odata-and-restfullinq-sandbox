using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using PersonApi.Models;
using PersonApi.Services;
using PersonModel.Models;
using RESTFulLinq;

namespace PersonApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonsController : ControllerBase
    {
        IPersonService _personService;

        public PersonsController(IPersonService personService) => _personService = personService;

        [HttpGet]
        [EnableQuery]
        public ActionResult<IQueryable<Person>> GetAllPerson()
        {
            return Ok(_personService.RetrieveAllPersons());
        }
        
        [HttpGet]
        [Route("ByLinq")]
        public async ValueTask<ActionResult<IQueryable<Person>>> GetAllPerson(string linqQuery)
        {
            IQueryable<Person> allPersons = _personService.RetrieveAllPersons();
            var results = await RESTFulLinqService.RunQueryAsync(linqQuery, 
                new Globals<Person>{ DataSource = allPersons});
            return Ok(results);
        }
    }
}
