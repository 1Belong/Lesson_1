namespace Task_2
{
    class Program
    {   
        static void Main()
        {
            Console.Write("Please enter first side of the rectangle: ");
            double side1 = double.Parse(Console.ReadLine());
            Console.Write("Please enter second side of the rectangle: ");
            double side2 = double.Parse(Console.ReadLine());
            Rectangle rectangle = new(side1, side2);
            Console.WriteLine($"Perimeter equals {rectangle.Perimeter}");
            Console.WriteLine($"Area equals {rectangle.Area}");
            
        }

    }

    class Rectangle
    {
        private double side1;
        private double side2;

        double AreaCalculator(double side1, double side2)
        { 
            return side1 * side2; 
        }
        public double Area
        {
            get { return AreaCalculator(side1, side2);  }
        }
        double PerimeterCalculator(double side1, double side2)
        {   
            return 2* (side1 + side2);
        }
        public double Perimeter
        {
            get { return PerimeterCalculator(side1, side2); }
        }

        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }
    }
}

