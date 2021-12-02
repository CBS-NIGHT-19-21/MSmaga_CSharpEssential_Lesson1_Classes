// !!!Realize the Object-oriented programming principle - Encapsulation (hiding the implementation).
// Encapsulate data set and methods for working on it as an object.
// Declarate class of this kind of objects.
// Declarate the method to constructor an object of this class.

// Declaration of the Methods-fields to access to fields of the object.
// This is contrary to encapsulation!!!

class Point
{
    // State fields of the Point object.
    private readonly int _x;
    private readonly int _y;
    private readonly string _name;

    // Method-field of Properties of the Point object.
    public int X { get { return _x; } }
    public int Y { get { return _y; } }
    public string Name { get { return _name; } }

    // Constructor of the Point object.
    public Point(string name, int x, int y)
    {
        _x = x;
        _y = y;
        _name = name;
    }
}
