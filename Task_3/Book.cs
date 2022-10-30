class Book
{
    Author author;
    Title title;
    Content content;

    public void Show()
    {
        author.Show();
        title.Show();
        content.Show();
    }

    public Book(Author author, Title title, Content content)
    {
        this.author = author;
        this.title = title;
        this.content = content;
    }
}


