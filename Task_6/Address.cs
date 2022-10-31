class Address
{
    private string? Index { get; set; }
    private string? Country { get; set; }
    private string? City { get; set; }
    private string? Street { get; set; }
    private string? House { get; set; }
    private string? Apartment { get; set; }

    public void ShowInfo()
    {   
        Console.WriteLine($"Index of address: {this.Index}");
        Console.WriteLine($"Location country is {this.Country}");
        Console.WriteLine($"Location city is {this.City}");
        Console.WriteLine($"Living on {this.Street} street");
        Console.WriteLine($"The address of house is {this.House}");
        Console.WriteLine($"The number of apartment is {this.Apartment}");
    }

    public Address()
    {
    }
    public Address(string index, string country, string city, string street, string house, string apartment)
    {
        this.Index = string.IsNullOrEmpty(index) ? "Unknown" : index;
        this.Country = string.IsNullOrEmpty(country) ? "Unknown" : country;
        this.City = string.IsNullOrEmpty(city) ? "Unknown" : city;
        this.Street = string.IsNullOrEmpty(street) ? "Unknown" : street;
        this.House = string.IsNullOrEmpty(house) ? "Unknown" : house;
        this.Apartment = string.IsNullOrEmpty(apartment) ? "Unknown" : apartment;
    }
}

