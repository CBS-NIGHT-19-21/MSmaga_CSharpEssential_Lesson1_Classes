// !!!Realize the Object-oriented programming principle - Encapsulate (hiding the implementation).
// Encapsulate data set and methods for working on it as an object.
// Declarate class of this kind of objects.

// Auto declarate the method to constructor an object of this class.

// Declaration of the Methods-fields to access to fields of the object.
// This is contrary to encapsulation!!!
class Address
{
    // Method-fields of Properties(Attributes) of the Address object.
    public string Index { get; set; } = default!;
    public string Country { get; set; } = default!;
    public string City { get; set; } = default!;
    public string Street { get; set; } = default!;
    public string House { get; set; } = default!;
    public string Apartment { get; set; } = default!;
}

