using System;

class Program
{
    static void Main(string[] args)
    {
        Circle circle = new Circle(15, "Red");
        Square square = new Square(15, "Black");
        Rectangle rectangle = new Rectangle(15, 5, "Blue");
        List<Shape> shapes = new List<Shape>();
        shapes.Add(circle);
        shapes.Add(square);
        shapes.Add(rectangle);

        foreach (var shape in shapes)
        {
            Console.WriteLine($"Color: {shape.GetColor()} Area: {shape.GetArea()}");
        }
        
    }
}