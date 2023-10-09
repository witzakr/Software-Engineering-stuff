using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("How many people?");
        int numPersons = int.Parse(Console.ReadLine());

        string[] names = new string[numPersons];
        int[] ages = new int[numPersons];

        for (int i = 0; i < numPersons; i++)
        {
            Console.WriteLine($"Enter name for person {i + 1}: ");
            names[i] = Console.ReadLine();

            Console.WriteLine($"Enter age for {names[i]}: ");
            ages[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Inputted data:");
        for (int i = 0; i < numPersons; i++)
        {
            Console.WriteLine($"{names[i]} - {ages[i]} years old");
        }
    }
}