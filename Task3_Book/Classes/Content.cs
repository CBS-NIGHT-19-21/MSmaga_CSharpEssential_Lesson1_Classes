
// !!!Realize the Object-oriented programming principle - Encapsulation (hiding the implementation).
// Encapsulate data set and methods for working on it as an object.
// Declarate class of this kind of objects.
// Declarate the method to constructor an object of this class.

// !!!Implement a way to organize interaction between classes - Composition : Association.
// Declarate class of this kind of objects as a mandatory member - a field of another class.

// Declaration of the Methods-fields to access to fields of the object.
// This is contrary to encapsulation!!!

// Create a Content property for the Book class
// in which we create the text field and the Text property.
class Content
{
    // The state field of the Content object.
    private string _text = default!;

    // Method-field Property of the Content object.
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
                return "Текста книги нет!";
            }
        }
        set
        {
            _text = value;
        }
    }

    // Method of the Content object.
    public void Show()
    {
        Console.WriteLine(Text);
    }

}

