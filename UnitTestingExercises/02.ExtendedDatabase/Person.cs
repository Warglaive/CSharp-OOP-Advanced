public class Person
{
    public long Id { get; }
    public string Name { get; }

    public Person(long id, string name)
    {
        this.Id = id;
        this.Name = name;
    }
}