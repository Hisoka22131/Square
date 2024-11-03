namespace Square.Core;

public class Triangle : IShape
{
    private double SideA { get; }
    private double SideB { get; }
    private double SideC { get; }

    public Triangle(double sideA, double sideB, double sideC)
    {
        if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            throw new ArgumentException("Sides must be positive.");

        if (!IsValidTriangle(sideA, sideB, sideC))
            throw new ArgumentException("The given sides do not form a valid triangle.");

        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
    }

    public double CalculateArea()
    {
        var semiPerimeter = (SideA + SideB + SideC) / 2;
        return Math.Sqrt(semiPerimeter * (semiPerimeter - SideA) * (semiPerimeter - SideB) * (semiPerimeter - SideC));
    }

    public bool IsRightTriangle()
    {
        var aSquared = SideA * SideA;
        var bSquared = SideB * SideB;
        var cSquared = SideC * SideC;

        return Math.Abs(aSquared + bSquared - cSquared) < 1e-10 ||
               Math.Abs(aSquared + cSquared - bSquared) < 1e-10 ||
               Math.Abs(bSquared + cSquared - aSquared) < 1e-10;
    }

    private static bool IsValidTriangle(double a, double b, double c)
    {
        return a + b > c && a + c > b && b + c > a;
    }
}