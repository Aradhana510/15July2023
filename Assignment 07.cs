using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        // Create an ArrayList
        ArrayList arrayList = new ArrayList();

        // Add elements to the ArrayList
        arrayList.Add("apple");
        arrayList.Add("banana");
        arrayList.Add("cherry");
        arrayList.Add("date");
        arrayList.Add("elderberry");

        // Print the total number of elements in the ArrayList
        Console.WriteLine("Total number of elements in the ArrayList: " + arrayList.Count);

        Console.WriteLine();

        // Check if the ArrayList contains the element "date"
        Console.WriteLine("ArrayList contains 'date': " + arrayList.Contains("date"));

        Console.WriteLine();

        // Insert the element "fig" at the second position in the ArrayList
        arrayList.Insert(1, "fig");

        // Remove the element "banana" from the ArrayList
        arrayList.Remove("banana");

        // Print all the elements in the ArrayList using a loop
        Console.WriteLine("Elements in the ArrayList:");
        foreach (var element in arrayList)
        {
            Console.WriteLine(element);
        }

        Console.ReadLine();
    }
}
