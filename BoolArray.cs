using System;

public class BoolArray
{
    private bool[] array;

    public BoolArray(int size)
    {
        array = new bool[size];
    }

    public bool this[int index]
    {
        get
        {
            if (index < 0 || index >= array.Length)
            {
                Console.WriteLine("Помилка: Індекс виходить за межі масиву!");
                return false;
            }
            return !array[index];
        }
        set
        {
            if (index < 0 || index >= array.Length)
            {
                Console.WriteLine("Помилка: Індекс виходить за межі масиву!");
                return;
            }
            array[index] = value;
        }
    }
    public bool LogicalOR
    {
        get
        {
            bool result = false;
            foreach (bool item in array)
            {
                result |= item;
            }
            return result;
        }
    }
}
