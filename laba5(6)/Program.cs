// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("length= ");
        double length = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("width= ");
        double width = Convert.ToDouble(Console.ReadLine());

        double area = CalculateRectangleArea(length, width);
        double volume = CalculateRectangleVolume(length, width);

        Console.WriteLine($"Площа прямокутника: {area}");
        Console.WriteLine($"Об'єм прямокутника: {volume}");
    }

    static double CalculateRectangleArea(double length, double width)
    {
        return length * width;
    }

    static double CalculateRectangleVolume(double length, double width)
    {
        
        return CalculateRectangleArea(length, width) * width;
    }
}
