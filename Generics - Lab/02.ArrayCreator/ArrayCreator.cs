using System.Collections.Generic;
public class ArrayCreator
{
    public static T[] Create<T>(int length, T item)
    {
        var result = new List<T>();
        for (int i = 0; i < length; i++)
        {
            result.Add(item);
        }
        return result.ToArray();
    }
}