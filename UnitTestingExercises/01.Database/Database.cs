using System;
using System.Linq;

public class Database
{
    public int[] IntegersDB;
    private const int arrayExactLength = 16;
    private int index;

    public Database(int[] integers)
    {
        if (integers.Length != arrayExactLength)
        {
            throw new InvalidOperationException();
        }
        this.IntegersDB = integers;
        this.index = 0;
    }

    public void Add(int integer)
    {
        if (this.IntegersDB.Length != 16)
        {
            throw new InvalidOperationException();
        }

        var emptyCellIndex = this.IntegersDB
            .FirstOrDefault(e => e.Equals(0));

        if (emptyCellIndex == 0)
        {
            this.IntegersDB[emptyCellIndex] = integer;
        }
    }

    public bool Remove()
    {
        if (this.IntegersDB.Length == 0)
        {
            throw new InvalidOperationException();
        }

        if (this.IntegersDB.Length == 0)
        {
            throw new InvalidOperationException();
        }

        //remove last element
        var oldLength = this.IntegersDB.Length;
        var newLength = this.IntegersDB.Length - 1;
        Array.Resize(ref this.IntegersDB, this.IntegersDB.Length - 1);
        if (this.IntegersDB.Length == newLength)
        {
            return true;
        }
        return false;
    }

    public int[] Fetch()
    {
        return this.IntegersDB;
    }
}