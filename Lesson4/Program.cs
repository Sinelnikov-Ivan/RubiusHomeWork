namespace Lesson4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cafe сafe1 = new Cafe("Бургер Кинг");               // Создаём экземпляр сafe1 с именем

            Visitors visitor1 = new Visitors("Mike", сafe1);    // Создаём посетителя visitor1 с именем и любимым кафе сafe1
            Visitors visitor2 = new Visitors("Kavin", сafe1);   // Создаём посетителя visitor2 с именем и любимым кафе сafe1
            Visitors visitor3 = new Visitors("Ben");            // Создаём посетителя visitor3 с именем 
            

            сafe1.BookTable(visitor1);                          // Бронируем столик в сafe1 для посетителя visitor1
            сafe1.BookTable(visitor3);                          // Бронируем столик в сafe1 для посетителя visitor3


            var order1 = new DoOrder(visitor1, сafe1);          // Посетитель1 делает заказ столика в сafe1 
            var order2 = new DoOrder(visitor2, сafe1);          // Посетитель2 делает заказ столика в сafe1 
            var order3 = new DoOrder(visitor3, сafe1);          // Посетитель3 делает заказ столика в сafe1 

            Console.ReadLine();
        }
    }


}
