class Program
{
    static void Main()
    {
        #region Задание Дополнительное

        // Создать класс с именем Address. 
        // В теле класса требуется создать поля: index, country, city, street, house, apartment.
        // Для каждого поля, создать свойство с двумя методами доступа. 
        // Создать экземпляр класса Address. 
        // В поля экземпляра записать информацию о почтовом адресе. Выведите на экран значения полей,
        // описывающих адрес. 
        #endregion

        #region Address - Encapsulation
        // Instantiate (create) an instance of address of the Address class.
        // Get a reference to the address of the instance on the heap (Heap)
        // by calling the default constructor.
        #endregion

        Address address = new()
        {
            Index = "063", 
            Country = "Ukraine",
            City = "Kyev",
            Street = "Svobody",
            House = "13",
            Apartment = "19"
        };

        // Show the auto properties of the instance.
        address.Show();


        // Delay.
        Console.ReadKey();
    }
}

