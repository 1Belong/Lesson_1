class Program
{
    static void Main()
    {
        Console.WriteLine("Choose amount of points in your figure from 3 to 5");
        int amountOfPoints = int.Parse(Console.ReadLine());
        Figure figure = new Figure(amountOfPoints);
        double perimeter =  figure.PerimeterCalculator();
        Console.WriteLine($"Perimeter of our figure equals {perimeter} and has a name {figure.NameOfFigure}");

    }

}