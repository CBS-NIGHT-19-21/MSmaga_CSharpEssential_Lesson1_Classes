
// !!!Realize the Object-oriented programming principle - Encapsulation (hiding the implementation).
// Encapsulate data set and methods for working on it as an object.
// Declarate class of this kind of objects.
// Declarate the method to constructor an object of this class.

// !!!Implement a way to organize interaction between classes - Composition : Association.
// Declarate class of this kind of objects as a mandatory member - a field of another class.

// Declaration of the Methods-fields to access to fields of the object.
// This is contrary to encapsulation!!!
class Title
{
    // State field of the Title object.
    private string? _text;

    // Method-field of Properties of the Title object.
    public string Text
    {
        private get
        {
            if (_text != null)
            {
                return _text;
            }

            else
            {
                return "Названия книги нет!";
            }
        }

        set
        {
            _text = value;
        }
    }

    // Method of the Title object.
    public void Show() => Console.WriteLine(Text);  
}

