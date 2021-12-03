    // !!!Realize the Object-oriented programming principle - Encapsulate (hiding the implementation).
    // Encapsulate data set and methods for working on it as an object.
    // Declarate class of this kind of objects.

    // Auto declarate the method to constructor an object of this class.

    // Declaration of the Methods-fields to access to fields of the object.
    // This is contrary to encapsulation!!!
    class Address
{   // Declare state fields of the Address instance.
    // Using default value of the type.
    private string _index = default!;
    private string _country = default!;
    private string _city = default!;
    private string _street = default!;
    private string _house = default!;
    private string _apartment = default!;

    // Method-fields of Properties(Attributes) of the Address object.
    public string Index { get { return _index!; } set { _index = value; } }
    public string Country { get { return _country; } set { _country = value; } }
    public string City { get { return _city; } set { _city = value; } }
    public string Street { get { return _street; } set { _street = value; } }
    public string House { get { return _house; } set { _house = value; } }
    public string Apartment { get { return _apartment; } set { _apartment = value; } }
}

