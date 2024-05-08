using System;
using System.Collections.Generic;

/// <summary>
/// Класс Set представляет простое множество целых чисел.
/// </summary>
public class Set
{
    /// <summary>
    /// Список для хранения элементов множества.
    /// </summary>
    private List<int> elements;

    /// <summary>
    /// Конструктор класса Set.
    /// </summary>
    public Set()
    {
        elements = new List<int>();
    }

    /// <summary>
    /// Добавляет элемент в множество.
    /// </summary>
    /// <param name="element">Элемент для добавления.</param>
    public void Add(int element)
    {
        if (!elements.Contains(element))
        {
            elements.Add(element);
        }
    }

    /// <summary>
    /// Удаляет элемент из множества.
    /// </summary>
    /// <param name="element">Элемент для удаления.</param>
    public void Remove(int element)
    {
        elements.Remove(element);
    }

    /// <summary>
    /// Возвращает объединение текущего и другого множества.
    /// </summary>
    /// <param name="other">Другое множество.</param>
    /// <returns>Объединение множеств.</returns>
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

    /// <summary>
    /// Возвращает пересечение текущего и другого множества.
    /// </summary>
    /// <param name="other">Другое множество.</param>
    /// <returns>Пересечение множеств.</returns>
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

    /// <summary>
    /// Возвращает разность текущего и другого множества.
    /// </summary>
    /// <param name="other">Другое множество.</param>
    /// <returns>Разность множеств.</returns>
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

    /// <summary>
    /// Печатает элементы множества.
    /// </summary>
    public void Print()
    {
        foreach (var element in elements)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }
}

/// <summary>
/// Класс Program содержит точку входа в программу.
/// </summary>
class Program
{
    /// <summary>
    /// Точка входа в программу.
    /// </summary>
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
