using System.Collections.Generic;
using System.Text;


public class SwapStrings<T>
{
    private List<T> PrintList;

    public void SwapElement(List<T> elements
        , int firstIndex, int secondIndex)
    {
        var temp = elements[firstIndex];
        elements[firstIndex] = elements[secondIndex];
        elements[secondIndex] = temp;
        this.PrintList = elements;
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        foreach (var currentElement in PrintList)
        {
            sb.AppendLine($"{currentElement.GetType().FullName}: {currentElement}");
        }
        return sb.ToString();
    }
}