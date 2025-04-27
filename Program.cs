using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Створення масиву на 3 елементи...");
        BoolArray myArray = new BoolArray(3);

        Console.WriteLine("\nЗапис значень: ");
        myArray[0] = false;
        myArray[1] = true;
        myArray[2] = false;
        myArray[3] = true;

        Console.WriteLine("\nЧитання значень: ");
        Console.WriteLine($"Елемент 0: {myArray[0]}");
        Console.WriteLine($"Елемент 1: {myArray[1]}");
        Console.WriteLine($"Елемент 2: {myArray[2]}");
        Console.WriteLine($"Елемент 3: {myArray[3]}");

        Console.WriteLine($"\nЛогічне OR всіх елементів: {myArray.LogicalOR}");

    }

}
