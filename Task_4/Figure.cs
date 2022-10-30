using static System.Math;

class Figure
{
    Point[] points;
    public string NameOfFigure { get; }

    public double LengthSide(Point A, Point B)
    {
        return Math.Sqrt(Math.Pow(A.X-B.X, 2) + Math.Pow(A.Y-B.Y, 2));
    }

    public double PerimeterCalculator()
    {
        double perimeter = 0;
        for (int i = 1; i < points.Length; i++)
        {
            perimeter += LengthSide(points[i - 1], points[i]);
        }
        perimeter += LengthSide(points[0], points[points.Length - 1]);
        return perimeter; 
    }



    public Figure(int amountOfPoints)
    {
        points = new Point[amountOfPoints];
        for (int i = 0; i < amountOfPoints; i++)
        { 
            Console.WriteLine($"\nInitialize our {i+1} figure");
            points[i] = new Point();
            NameOfFigure += points[i].Name;
        }
    }
}

