using System;
using System.Linq;

public class Database
{
    private Person[] peopleDB;
    private Person person;
    private const int arrayExactLength = 16;
    private int index;

    public Database(Person[] people)
    {
        if (people.Length != arrayExactLength)
        {
            throw new InvalidOperationException();
        }
        //
        this.peopleDB = new Person[people.Length];
        this.index = 0;
    }

    public void Add(Person addPerson)
    {
        if (this.peopleDB.Length == 16)
        {
            throw new InvalidOperationException();
        }

        if (this.peopleDB.Any(n => n.Name == addPerson.Name))
        {
            throw new InvalidOperationException();
        }

        if (this.peopleDB.Any(n => n.Id == addPerson.Id))
        {
            throw new InvalidOperationException();
        }
        //add if name is empty string
        if (this.peopleDB[index].Name == null)
        {
            this.peopleDB[index] = addPerson;
            index++;
        }
        else
        {
            index++;
        }
    }

    public void Remove()
    {
        if (this.peopleDB.Length == 0)
        {
            throw new InvalidOperationException();
        }
        //remove last element
        Array.Resize(ref this.peopleDB, this.peopleDB.Length - 1);

        if (this.peopleDB.Length == 0)
        {
            throw new InvalidOperationException();
        }
    }

    public void FindByUsername(string username)
    {
        var result = this.peopleDB.FirstOrDefault(p => p.Name == username);

        if (result == null)
        {
            throw new InvalidOperationException();
        }

        if (result.Name == null && result.Id != null)
        {
            throw new ArgumentNullException();
        }
    }

    //public int[] Fetch()
    //{
    //    return this.peopleDB;
    //}
}