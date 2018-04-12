using System;
using System.Collections.Generic;

namespace _03.IteratorTest
{
    public class ListIterator
    {
        public List<string> Elements;
        public int Index;

        public ListIterator(string[] collection)
        {
            if (collection == null)
            {
                throw new ArgumentNullException();
            }
            this.Elements = new List<string>(collection);
            this.Index = 0;
        }

        public bool Move()
        {
            if (HasNext())
            {
                this.Index++;
                return true;
            }
            return false;
        }

        public bool HasNext()
        {
            var next = this.Index + 1;
            if (next < this.Elements.Count)
            {
                return true;
            }
            return false;
        }

        public void Print()
        {
            if (this.Elements.Count == 0)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }
            Console.WriteLine($"{this.Elements[this.Index]}");
        }
    }
}