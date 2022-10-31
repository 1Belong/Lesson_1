class Program
{
    static void Main()
    {
        Console.WriteLine("Enter info about your living address");
        Console.WriteLine();
        Console.Write("Enter index of your location: ");
        string index = Console.ReadLine();
        Console.Write("Enter country where you living: ");
        string country = Console.ReadLine();
        Console.Write("Enter city where you living: ");
        string city = Console.ReadLine();
        Console.Write("Enter street where your house located: ");
        string street = Console.ReadLine();
        Console.Write("Enter number of your house: ");
        string house = Console.ReadLine();
        Console.Write("Enter number of your apartment: ");
        string apartment = Console.ReadLine();  
        Address address = new Address(index, country, city, street, house, apartment);
        Console.WriteLine();
        address.ShowInfo();
    }
}