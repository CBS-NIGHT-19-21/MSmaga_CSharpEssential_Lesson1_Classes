namespace Task_Additional_Address
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Задание Дополнительное
            // Используя Visual Studio, создайте проект по шаблону Console Application. 
            // Требуется: 
            // Создать класс с именем Address. 
            // В теле класса требуется создать поля: index, country, city, street, house, apartment. Для каждого 
            // поля, создать свойство с двумя методами доступа. 
            // Создать экземпляр класса Address. 
            // В поля экземпляра записать информацию о почтовом адресе. Выведите на экран значения полей, описывающих адрес. 
            #endregion

            #region Address - Encapsulation

            // Instantiate (create) an instance of address of the Address class.
            // Get a reference to the address of the instance on the heap (Heap) by calling the default constructor.

            Address address = new Address()
            {
                Index = "063",
                Country = "Ukraine",
                City = "Kyev",
                Street = "Svobody",
                House = "13",
                Apartment = "19"
            };

            // Show the auto properties of the instance.
            Console.WriteLine($"Index = {address.Index}, Country = {address.Country}, City = {address.City}, " +
                              $"Street = {address.Street}, House = {address.House}, Apartment = {address.Apartment}");

            #endregion

            // Delay.
            Console.ReadKey();

        }
    }
}

