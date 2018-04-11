using System;
using System.Linq;

public class Database
{
    private Person[] peopleDB;
    private const int arrayExactLength = 16;
    private int index;

    public Database(Person[] people)
    {
        if (people.Length != arrayExactLength)
        {
            throw new InvalidOperationException();
        }
        //
        this.peopleDB = people;
        this.index = 0;
    }

    public void Add(Person addPerson)
    {
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

    public bool Remove()
    {
        if (this.peopleDB.Length == 0)
        {
            throw new InvalidOperationException();
        }

        if (this.peopleDB.Length == 0)
        {
            throw new InvalidOperationException();
        }

        //remove last element
        var oldLength = this.peopleDB.Length;
        var newLength = this.peopleDB.Length - 1;
        Array.Resize(ref this.peopleDB, this.peopleDB.Length - 1);
        if (this.peopleDB.Length == newLength)
        {
            return true;
        }
        return false;
    }

    public Person FindByUsername(string username)
    {
        var result = this.peopleDB.FirstOrDefault(p => p.Name == username);

        if (result == null)
        {
            throw new InvalidOperationException();
        }

        if (result.Name == null)
        {
            throw new ArgumentNullException();
        }
        return result;
    }

    public Person FindById(long id)
    {
        var result = this.peopleDB.FirstOrDefault(p => p.Id == id);

        if (result == null)
        {
            throw new InvalidOperationException();
        }

        if (result.Id < 0)
        {
            throw new ArgumentOutOfRangeException();
        }
        return result;
    }
    public Person[] Fetch()
    {
        return this.peopleDB;
    }
}