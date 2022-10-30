
class Program
{
    static void Main()
    {
        Author author = new Author();
        Console.Write("Enter name of the author: ");
        string? name = Console.ReadLine();
        author.Name = string.IsNullOrWhiteSpace(name) ? "Name is empty" : name;

        Title title = new Title();
        Console.Write("Enter head of the title: ");
        string? head = Console.ReadLine();
        title.Head = string.IsNullOrWhiteSpace(head) ? "Head is empty" : head;


        Content content = new Content();
        Console.Write("Enter description of the book: ");
        string? description = Console.ReadLine();
        content.Description = string.IsNullOrWhiteSpace(description) ? "Description is empty" : description;

        Book book = new Book(author, title, content);
        book.Show();
    }
}

