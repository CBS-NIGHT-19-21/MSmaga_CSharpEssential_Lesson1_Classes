class Program
{
    static void Main()
    {
        #region Задание 2
        // Требуется: Создать класс с именем Rectangle. 
        // В теле класса создать два поля, описывающие длины сторон double side1, side2. 
        // Создать пользовательский конструктор Rectangle(double side1, double side2), в теле которого 
        // поля side1 и side2 инициализируются значениями аргументов. 
        // Создать два метода, вычисляющие площадь прямоугольника - double AreaCalculator() и периметр 
        // прямоугольника - double PerimeterCalculator(). 
        // Создать два свойства double Area и double Perimeter с одним методом доступа get.
        // Написать программу, которая принимает от пользователя длины двух сторон прямоугольника и выводит 
        // на экран периметр и площадь. 
        #endregion

        #region Rectangle - Encapsulation

        // Instantiate (create) an instance of the class.
        // New request to allocate memory on the heap (Heap)
        // i.e. getting a reference to the address
        // of the instance and the object of the class.
        Rectangle RectInstance = new(13, 19);

        // Accessing the Properties of the class object, the fields are closed.
        // Point is an operator of access to Properties or Methods of an object.
        Console.WriteLine($"Area: {RectInstance.Area}, Perimeter: {RectInstance.Perimeter}");

        #endregion

        // Delay.
        Console.ReadLine();
    }
}


