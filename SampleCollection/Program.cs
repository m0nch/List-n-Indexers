using System;
using System.Collections.Generic;

class SampleCollection
{
    // Declare a list to store the data elements.
    private string[] arr = new string[100];
    // Define the indexer to allow client code to use [] notation.
    public string this[int i]
    {
        get { return arr[i]; }
        set { arr[i] = value; }
    }
}

class Program
{
    static void Main()
    {
        List<string> newList = new List<string>();
        var stringCollection = new SampleCollection();
        for (int i = 0; i < 10; i++)
        {
            Console.Write("Input word: ");
            stringCollection[i] = Convert.ToString(Console.ReadLine());
            newList.Add(stringCollection[i]);
            //Console.WriteLine(stringCollection[i]);
        }
        for (int i = 0; i < newList.Count; i++)
        {
            Console.Write($"{newList[i]}, ");
        }
    }
}
