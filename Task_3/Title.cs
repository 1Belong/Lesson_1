class Title
{
    public string? Head { get; set; }

    public void Show()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(Head);
    }
}

