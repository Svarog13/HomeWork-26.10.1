using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the side length of the square: ");
        int sideLength = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the character to draw the square: ");
        char character = char.Parse(Console.ReadLine());

        DrawSquare(sideLength, character);
    }

    static void DrawSquare(int sideLength, char character)
    {
        if (sideLength <= 0)
        {
            Console.WriteLine("Side length must be a positive integer.");
            return;
        }
        for (int i = 0; i < sideLength; i++)
        {
            for (int j = 0; j < sideLength; j++)
            {
                Console.Write(character + " ");
            }
            Console.WriteLine();
        }
    }
}