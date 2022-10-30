class Point
{
    public int X { get; }
    public int Y { get; }
    public string Name { get; }


    public Point()
    {
        Console.WriteLine("Enter X: ");
        this.X = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Y: ");
        this.Y = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter name of point");
        this.Name = Console.ReadLine();
    }
}

