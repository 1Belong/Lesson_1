class Content
{
    public string? Description { get; set; }

    public void Show()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine(Description);
        Console.ForegroundColor = ConsoleColor.White;
    }
}
