using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("red", 22f);

        Rectangle rectangle = new Rectangle(25f, 10f, "green");

        Circle circle = new Circle(15, "blue");

        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
            Console.WriteLine();
        }
    }
}