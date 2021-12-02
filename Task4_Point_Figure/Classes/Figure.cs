// !!!Realize the Object-oriented programming principle - Encapsulation (hiding the implementation).
// Encapsulate data set and methods for working on it as an object.
// Declarate class of kind of objects.
// Declarate the method to constructor an object of class.

// Declaration of the Methods-fields to access to fields of the object.
// is contrary to encapsulation!!!
class Figure
{   // State fields of the Figure object.
    private Point _point1 = default!;
    private Point _point2 = default!;
    private Point _point3 = default!;
    private Point _point4 = default!;
    private Point _point5 = default!;

    private double _length;
    private double _perimeter;

    // Constructor of an object of the Figure class using 3 arguments.
    public Figure(Point point1, Point point2, Point point3)
    {
        _point1 = point1;
        _point2 = point2;
        _point3 = point3;
    }

    // Constructor of an object of the Figure class using 4 arguments.
    public Figure(Point point1, Point point2, Point point3, Point point4)
    {
        _point1 = point1;
        _point2 = point2;
        _point3 = point3;
        _point4 = point4;
    }

    // Constructor of an object of the Figure class using 5 arguments.
    public Figure(Point point1, Point point2, Point point3, Point point4, Point point5)
    {
        _point1 = point1;
        _point2 = point2;
        _point3 = point3;
        _point4 = point4;
        _point5 = point5;
    }

    // Method-field of Properties of the Figure object.
    public Point Point
    { get { return _point1; } set { _point1 = value; } }
    public Point Point2
    { get { return _point2; } set { _point2 = value; } }
    public Point Point3
    { get { return _point3; } set { _point3 = value; } }
    public Point Point4
    { get { return _point4; } set { _point4 = value; } }
    public Point Point5
    { get { return _point5; } set { _point5 = value; } }
    public double Perimeter
    { get { return _perimeter; } set { _perimeter = value; } }
    public double Length
    { get { return _length; } set { _length = value; } }

    /// <summary>
    /// Gets Side Length
    /// </summary>
    /// <param name="_point1"></param>
    /// <param name="_point2"></param>
    /// <returns>double LengthSide</returns>
    public double GetLengthSide(Point point1, Point point2)
    {

        //Check conditions into a bool variable
        bool isWholeness = (point1 != null) && (point2 != null);

        if (isWholeness)
        {

            return Math.Sqrt(Math.Pow(point2.X - point1.X, 2) + Math.Pow(point2.Y - point1.Y, 2));
        }

        else
        {
            return 0;
        }
    }

    /// <summary>
    /// Calcs Perimeter using 3 arguments
    /// </summary>
    /// <param name="_point1"></param>
    /// <param name="_point2"></param>
    /// <param name="_point3"></param>
    public void CalcPerimeter(Point point1, Point point2, Point point3)
    {
        //Check conditions into a bool variable
        bool isWholeness = (point1 != null) && (point2 != null) && (point3 != null);

        if (isWholeness)
        {
            _perimeter = GetLengthSide(point1, point2) +
                              GetLengthSide(point2, point3) +
                              GetLengthSide(point3, point1);
        }

        else
        {
            _perimeter = 0;
        }
    }

    /// <summary>
    /// Calcs Perimeter using 4 arguments
    /// </summary>
    /// <param name="_point1"></param>
    /// <param name="_point2"></param>
    /// <param name="_point3"></param>
    /// <param name="_point4"></param>
    public void CalcPerimeter(Point point1, Point point2, Point point3, Point point4)
    {
        //Check conditions into a bool variable
        bool isWholeness = (point1 != null) && (point2 != null) &&
                           (point3 != null) && (point4 != null);

        if (isWholeness)
        {
            _perimeter = GetLengthSide(point1, point2) +
                              GetLengthSide(point2, point3) +
                              GetLengthSide(point3, point4) +
                              GetLengthSide(point4, point1);
        }

        else
        {
            _perimeter = 0;
        }

    }

    /// <summary>
    /// Calcs Perimeter using 5 arguments
    /// </summary>
    /// <param name="_point1"></param>
    /// <param name="_point2"></param>
    /// <param name="_point3"></param>
    /// <param name="_point4"></param>
    /// <param name="_point5"></param>
    public void CalcPerimeter(Point point1, Point point2, Point point3, Point point4, Point point5)
    {
        bool isWholeness = (point1 != null) && (point2 != null) &&
                           (point3 != null) && (point4 != null) &&
                           (point5 != null);

        if (isWholeness)
        {
            _perimeter = GetLengthSide(_point1, _point2) +
                              GetLengthSide(_point2, _point3) +
                              GetLengthSide(_point3, _point4) +
                              GetLengthSide(_point4, _point5) +
                              GetLengthSide(_point5, _point1);
        }

        else
        {
            _perimeter = 0;
        }
    }
}

