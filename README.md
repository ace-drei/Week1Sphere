# Week1Sphere

Exercise: 
You are required to design and develop a program in C# which stores and calculates information about 3D shapes. 
The program will be made up of several classes: 
ThreeDShape class
1.	Implement an abstract class ThreeDShape
2.	The class should have a field which stores the type of the shape (e.g. sphere, cylinder, cone etc.), and a public read-only property corresponding to this field.
3.	Implement appropriate constructors for the class.
4.	Implement an abstract method which calculates the volume of the shape. 
5.	Override the ToString() method inherited from System.Object, make it display information about the shape.
6.	Test the class. Try to create instances of the class and call methods.
 
Sphere class
1.	A sphere "is a" ThreeDShape
2.	The class should have field to store the radius of the sphere, and a read-write property corresponding to the field. The radius must be always positive.
3.	Implement appropriate constructors for the class.
4.	 Override the method to calculate the volume i.e. the volume of a sphere is PI * radius * radius * radius.
5.	Override the ToString() method inherited from ThreeDShape, make it display information about the sphere.
6.	Test the class. Call the method to calculate the volume of a sphere polymorphically. Display details of the sphere object. Make a collection of spheres and call various methods on each sphere
