#region Задание 4
// Используя Visual Studio, создайте проект по шаблону Console Application. 
// Требуется: 
// Создать классы Point и Figure. 
// Класс Point должен содержать два целочисленных поля и одно строковое поле. 
// Создать три свойства с одним методом доступа get. 
// Создать пользовательский конструктор, в теле которого проинициализируйте поля значениями 
// аргументов. Класс Figure должен содержать конструкторы, которые принимают от 3-х до 5-ти 
// аргументов типа Point. 
// Создать два метода: double LengthSide(Point A, Point B), который рассчитывает длину 
// стороны многоугольника; void PerimeterCalculator(), который рассчитывает периметр 
// многоугольника. 
// Написать программу, которая выводит на экран название и периметр многоугольника.
#endregion

#region Points - Encapsulation

// Instantiation (creation) of instances of point1-5 of the Point class.
// Get links to the address of instances on the heap (Heap)
// using a call to the custom constructor
// with actual parameters "Point_1", 13, 19 ...

Point point1 = new Point("Tочка_1", 13, 19);
Point point2 = new Point("Tочка_2", 13, 51);
Point point3 = new Point("Tочка_3", 17, 51);
Point point4 = new Point("Tочка_4", 17, 19);

// Accessing properties of point1-5 instances and output to the console.
Console.WriteLine($"{point1.Name} : Х = {point1.X},  Y = {point1.Y};");
Console.WriteLine($"{point2.Name} : Х = {point2.X},  Y = {point2.Y};");
Console.WriteLine($"{point3.Name} : Х = {point3.X},  Y = {point3.Y};");
Console.WriteLine($"{point4.Name} : Х = {point4.X},  Y = {point4.Y};");

// Instantiate (create) an instance of figure1 of the Figure class
// Get a reference to the address of the instance on the heap (Heap)
// using a call to the custom constructor
// with actual parameters - objects point1, point2, point3, point4.
Figure figure1 = new Figure(point1, point2, point3, point4);

// Call the GetLengthSide method of the Figure object containing the methods
// through an instance of figure1 containing a reference to the object
// and assigning to the Length property of the figure1 object of the Figure class.
figure1.Length = figure1.GetLengthSide(point1, point2);

Console.WriteLine($"\nLengthSide = {figure1.Length};");

// Call the CalcPerimeter method of the Figure object containing the methods
// through an instance of figure1 containing a reference to the object.
figure1.CalcPerimeter(point1, point2, point3, point4);

// Display the Perimeter property of the figure1 instance.
Console.WriteLine($"\nPerimeter = {figure1.Perimeter};");

#endregion
