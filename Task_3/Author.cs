class Author
{
    public string? Name { get; set; }

    public void Show()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(Name);
    }
}

