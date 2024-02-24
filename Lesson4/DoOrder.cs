using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    internal class DoOrder
    {
        public DoOrder(Visitor visitor, Cafe cafe)
        {

            bool checkBookTable = false;                                            // Переменная для проверки факта заказа столика

            for (int i = 0; i < cafe.ListVisitorsCafe.Count; i++)
            {                
                if ((visitor.name.Equals(cafe.ListVisitorsCafe[i].name))            // Посетитель забронировал столик?
                && (visitor.favoriteCafe.Equals(cafe.name)))                        // Посетитель является постоянным клиентом?
                {

                Console.WriteLine($"Посетитель {visitor.name} есть в списке тех кто забронировал столик, поэтому успешно сделал заказ и получил скидку как постоянный клиент в кафе {cafe.name}");
                checkBookTable = true;
                break;


                }
                               
                if (visitor.name.Equals(cafe.ListVisitorsCafe[i].name))             // Посетитель забронировал столик?
                {

                Console.WriteLine($"Посетитель {visitor.name} есть в списке тех кто забронировал столик, поэтому успешно сделал заказ в кафе {cafe.name}");
                checkBookTable = true;
                break;

                Console.WriteLine($"Посетитель {visitor.name} есть в списке тех кто забронировал столик, поэтому успешно сделал заказ в кафе {cafe.name}");
                checkBookTable = true;
                break;
                }                 
            }
                if (checkBookTable == false)                                            // Посетитель не забронировал столик/
            {
                Console.WriteLine($"Посетитель {visitor.name} не забронировал столик и его заказ в кафе {cafe.name} не выполнен");
            }

                    Console.WriteLine($"Посетитель {visitor.name} есть в списке тех кто забронировал столик, поэтому успешно сделал заказ в кафе {cafe.name}");
                    checkBookTable = true;
                    break;

                }                 
            }
            if (checkBookTable == false)                                            // Посетитель не забронировал столик/
            {
                Console.WriteLine($"Посетитель {visitor.name} не забронировал столик и его заказ в кафе {cafe.name} не выполнен");
            }
        }         
    }
        
}

