
class Program
{
    static void Main()
    {
        #region Задание 3
        //Используя Visual Studio, создайте проект по шаблону Console Application. 
        //Требуется: 
        //Создать класс Book. Создать классы Title, Author и Content, каждый из которых должен содержать 
        //одно строковое поле и метод void Show(). 
        //Реализуйте возможность добавления в книгу названия книги, имени автора и содержания. 
        //Выведите на экран разными цветами при помощи метода Show() название книги, имя автора и 
        //содержание.
        #endregion

        #region Book - Encapsulation - Composition : Association

        // Instantiate (create) an instance of book1 of the Book class.
        // Get a reference to the address of the instance on the heap (Heap)
        // using a call to the custom constructor
        // with the actual parameter "Alice's Adventures in Wonderland".
        Book book1 = new("Alice's Adventures in Wonderland");

        // Calling the Author property of the Book1 instance of the Book class
        // which is an object of class Author with a Text property.
        book1.Author = "Carol Lewis";

        // Calling the Author property of the Book1 instance of the Book class
        // which is an object of class Author with a Text property.
        book1.Content = "ALICE was beginning to get very tired....";

        // Call the Show () method of the Book class object containing methods
        // through an instance of book1 containing a reference to the object.
        book1.Show();

        #endregion
    }
}


