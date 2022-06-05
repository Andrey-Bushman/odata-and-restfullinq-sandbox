namespace PersonModel.Models;

public class ValueInfo<T>
{
    public Guid Id { get; set; }
    public T Value { get; set; }
    public string Description { get; set; }
}