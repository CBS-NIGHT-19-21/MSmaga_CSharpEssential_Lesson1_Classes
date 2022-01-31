class Book
{
    // Create the fields of the Book class as objects
    // of the Title, Author, Content classes.
    private readonly Title _title = default!;
    private readonly Author _author = default!;
    private readonly Content _content = default!;

    // Create a constructor method of the Book class to initialize its fields
    // as objects of classes Title, Author, Content.
    // To the Text property of the Title object - which is the title property of the Book object
    // assign the actual title parameter.
    public Book(string title)
    {
        _title = new Title();
        _title.Text = title;
        _author = new Author();
        _content = new Content();
    }

    // Declare the Author, Content Properties of the Book object.
    public string Author
    { set { _author.Text = value; } }

    public string Content
    { set { _content.Text = value; } }

    // Create a method of the Book object as
    // calls to methods of objects - title, author, content of the Book properties.
    public void Show()
    {
        Console.Write("Title: ");
        _title.Show();

        Console.Write("Author: ");
        _author.Show();

        Console.Write("Content: ");
        _content.Show();
    }
}

