using System;
using System.Collections.Generic;

public class Set
{
    private List<int> elements;

    public Set()
    {
        elements = new List<int>();
    }

    public void Add(int element)
    {
        if (!elements.Contains(element))
        {
            elements.Add(element);
        }
    }

    public void Remove(int element)
    {
        elements.Remove(element);
    }

    public Set Union(Set other)
    {
        Set result = new Set();
        foreach (var element in this.elements)
        {
            result.Add(element);
        }
        foreach (var element in other.elements)
        {
            result.Add(element);
        }
        return result;
    }

    public Set Intersection(Set other)
    {
        Set result = new Set();
        foreach (var element in this.elements)
        {
            if (other.elements.Contains(element))
            {
                result.Add(element);
            }
        }
        return result;
    }

    public Set Difference(Set other)
    {
        Set result = new Set();
        foreach (var element in this.elements)
        {
            if (!other.elements.Contains(element))
            {
                result.Add(element);
            }
        }
        return result;
    }

    public void Print()
    {
        foreach (var element in elements)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        Set set1 = new Set();
        set1.Add(1);
        set1.Add(2);
        set1.Add(3);
        Console.Write("Множество 1: ");
        set1.Print();

        Set set2 = new Set();
        set2.Add(3);
        set2.Add(4);
        set2.Add(5);
        Console.Write("Множество 2: ");
        set2.Print();

        Set union = set1.Union(set2);
        Console.Write("Объединение: ");
        union.Print();

        Set intersection = set1.Intersection(set2);
        Console.Write("Пересечение: ");
        intersection.Print();

        Set difference = set1.Difference(set2);
        Console.Write("Разность: ");
        difference.Print();
    }
}
