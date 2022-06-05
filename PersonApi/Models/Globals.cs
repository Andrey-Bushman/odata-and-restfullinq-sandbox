using RESTFulLinq.Models;

namespace PersonApi.Models;

public class Globals<T>:IGlobals<T>
{
    public IEnumerable<T> DataSource { get; set; }
}