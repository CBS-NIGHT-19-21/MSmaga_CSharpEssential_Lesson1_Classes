class Rectangle
{
    // Declaration of fields - the state of the class object (class member),
    // with a private access modifier for access from outside this class.
    private readonly double _side1;
    private readonly double _side2;
    private readonly double _area;
    private readonly double _perimeter;

    // Declaration of the Method-field Area (Properties)
    // of the class object (class member),
    // with an open access modifier for access from outside this class.
    public double Area
    {
        get
        {
            return _area;
        }
    }

    // Declaration of the Method-field Perimeter (Properties)
    // of the class object (class member),
    // with an open access modifier for access from outside this class.
    public double Perimeter
    {
        get
        {
            return _perimeter;
        }
    }

    // Declare a custom class constructor,
    // with input formal parameters
    // and a public access modifier for access from outside this class.
    public Rectangle(double side1, double side2)
    {
        // Assigning input parameters to the object's fields
        // using members - methods of this class.
        _side1 = side1;

        _side2 = side2;

        // Calling the area and perimeter fields and the method
        // of the class object
        // through an instance of a class that has a link
        // to an object containing methods.
        _area = CalcArea();

        _perimeter = CalcPerimeter();
    }

    // Declaration of the CalcArea() method - a member of the class,
    // with a private access modifier for access from outside this class,
    // that is, Encapsulations - implementation hiding.

    /// <summary>
    /// Calc Area
    /// </summary>
    /// <returns>double</returns>
    private double CalcArea()
    {
        return _side1 * _side2;
    }

    // Declaration of the CalcPerimeter() method - a member of the class,
    // with a private access modifier for access from outside this class,
    // that is, Encapsulations - implementation hiding.

    /// <summary>
    /// Calcs perimeter
    /// </summary>
    /// <returns>double</returns>
    private double CalcPerimeter()
    {
        return 2 * (_side1 + _side2);
    }
}

