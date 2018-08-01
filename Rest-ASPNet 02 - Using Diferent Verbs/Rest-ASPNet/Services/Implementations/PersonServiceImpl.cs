using System;
using System.Collections.Generic;
using System.Threading;

namespace Rest-ASPNet.Services.Implementations
{
    public class PersonServiceImpl : IPersonService
{
    private volatile int count;

    public Person Create(Person person)
    {
        return person;
    }

    public void Delete(long id)
    {
    }

    public List<Person> FindAll()
    {
        List<Person> persons = new List<Person>();
        for (int i = 0; i < 8; i++)
        {
            Person person = MockPerson(i);
            persons.Add(person);
        }
        return persons;
    }

    public Person FindById(long id)
    {
        return new Person
        {
            Id = IncremendAndGet(),
            FirstName = "Ricardo",
            LastName = "Teixeira",
            Address = "Rua do Acre , 356 - Patos de Minas",
            Gender = "Male"
        };
    }

    public Person Update(Person person)
    {
        return person;
    }

    private Person MockPerson(int i)
    {
        return new Person
        {
            Id = IncremendAndGet(),
            FirstName = "Person Name" + i,
            LastName = "Person Last Name",
            Address = "Some Address",
            Gender = "Male"
        };
    }

    private long IncremendAndGet()
    {
        return Interlocked.Increment(ref count);
    }
}
}
