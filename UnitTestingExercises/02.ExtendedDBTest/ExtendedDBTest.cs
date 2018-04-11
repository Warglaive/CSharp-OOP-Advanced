using NUnit.Framework;

public class ExtendedDbTest
{
    private Person[] people;
    [Test]
    public void Ctor_ThrowException_WhenMoreThan16ElementsInEntryArray()
    {
        this.people = new Person[16];
        var theSeventeenth = new Person(17, "malkiq");
        for (int i = 0; i < this.people.Length; i++)
        {
            this.people[i] = theSeventeenth;
        }
        Assert.That(() => new Database(this.people)
            .Add(theSeventeenth), Throws.InvalidOperationException);
    }

    [Test]
    public void Add_ThrowException_WhenUsernameExists()
    {
        this.people = new Person[16];

        for (int i = 0; i < this.people.Length; i++)
        {
            var first15Persons = new Person(i, $"{i}+Number");
            this.people[i] = first15Persons;
        }
        //test with same name, different Id
        var casualPerson = new Person(1, "1+Number");
        Assert.That(() => new Database(this.people)
                .Add(casualPerson)
            , Throws.InvalidOperationException);
    }

    [Test]
    public void Add_ThrowException_WhenIdExists()
    {
        this.people = new Person[16];
        for (int i = 0; i < this.people.Length; i++)
        {
            var first15Persons = new Person(i, $"{i}+Number");
            this.people[i] = first15Persons;
        }
        //test with different name and same Id
        var casualPerson = new Person(1, "99+Number");
        Assert.That(() => new Database(this.people)
                .Add(casualPerson)
            , Throws.InvalidOperationException);
    }
    //
    [Test]
    public void Remove_Element_FromEmptyDB()
    {
        this.people = new Person[16];
        for (int i = 0; i < this.people.Length; i++)
        {
            var first15Persons = new Person(i, $"{i}+Number");
            this.people[i] = first15Persons;
        }
        Assert.That((=>new Database(this.people).Remove())
            ,Is.);
    }
}