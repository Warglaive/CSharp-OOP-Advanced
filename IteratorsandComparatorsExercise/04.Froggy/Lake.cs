using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class Lake : IEnumerable<int>
{
    public List<int> stonesNumbers;

    public Lake(List<int> numbers)
    {
        this.stonesNumbers = new List<int>(numbers);
    }

    public IEnumerator<int> GetEnumerator()
    {
        for (int i = 0; i < this.stonesNumbers.Count; i += 2)
        {
            yield return this.stonesNumbers[i];
        }

        var reverseStartPoint = this.stonesNumbers.Count - 1;

        if (this.stonesNumbers.Count % 2 != 0)
        {
            reverseStartPoint = this.stonesNumbers.Count - 2;
        }

        for (int i = reverseStartPoint; i > 0; i -= 2)
        {
            yield return this.stonesNumbers[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}