using Microsoft.VisualBasic.CompilerServices;

namespace PersonModel.Models;

public class Person
{
    public Guid Id { get; set; }
    public Gender Gender { get; set; }
    public DateTime BirthDate { get; set; }
    public DateTime? DeathDate { get; set; }
    public string FirstName { get; set; }
    public string MiddleName { get; set; }
    public string LastName { get; set; }
    public ValueInfo<string>[] Phones { get; set; }
    public ValueInfo<string>[] Emails { get; set; }
}