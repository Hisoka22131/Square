using Square.Core;

IShape circle = new Circle(5);
Console.WriteLine($"Area of the circle: {circle.CalculateArea()}");

Triangle triangle = new Triangle(3, 4, 5);
Console.WriteLine($"Area of the triangle: {triangle.CalculateArea()}");
Console.WriteLine($"Is the triangle right-angled? {triangle.IsRightTriangle()}");
