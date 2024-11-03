using Square.Core;

namespace Square.UnitTests;

public class ShapeTests
{
    [Fact]
    public void CircleAreaTest()
    {
        IShape circle = new Circle(5);
        Assert.Equal(Math.PI * 25, circle.CalculateArea(), 5);
    }

    [Fact]
    public void TriangleAreaTest()
    {
        Triangle triangle = new Triangle(3, 4, 5);
        Assert.Equal(6, triangle.CalculateArea(), 5);
    }

    [Fact]
    public void RightTriangleTest()
    {
        Triangle triangle = new Triangle(3, 4, 5);
        Assert.True(triangle.IsRightTriangle());
    }

    [Fact]
    public void InvalidTriangleTest()
    {
        Assert.Throws<ArgumentException>(() => new Triangle(1, 2, 3));
    }
}