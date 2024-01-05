using System;
using System.Runtime.InteropServices;
using Shapes;

class ShapeTest
{
    public static void Main()
    {
        Sphere sphere = new Sphere(5);
        Sphere sphere1 = new Sphere(-5);

        Console.WriteLine(sphere);
        Console.WriteLine(sphere1);

    }
}