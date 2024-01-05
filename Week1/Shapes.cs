using System;
namespace Shapes;


public abstract class ThreeDShape
{
    string shapeType;

    //public read only property
    public string ShapeType
    {
        get { return shapeType; }
    }

    //Constructor
    public ThreeDShape(string type)
    {
        shapeType = type;
    }

    ~ThreeDShape()
    {
        Console.WriteLine("Called the Deconstructor");
    }

    //Abstract method
    public abstract double volume();


}



public class Sphere : ThreeDShape
{
    //field to store radius
    private double radius;

    //Making sure Radius is postive
    public double Radius
    {
        get { return radius; }
        set
        {
            if (value > 0)
                radius = value;
            else
                throw new ArgumentException("Radius must be positive.");
        }
    }

    public Sphere(double radius) : base("Sphere")
    {
        this.Radius = radius;
    }



    //overrides volume
    public override double volume()
    {
        return Math.PI * radius * radius * radius;
    }


    //Creates constructor in Sphere 
  
    public override string ToString()
    {
        return  "Radius = " + radius + " \nCalculate volume =  " + volume();
    }

}

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



interface IHasVolume
{
    void Volume(double volume);
}

