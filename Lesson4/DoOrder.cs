using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    internal class DoOrder
    {
        public DoOrder(Visitors visitor, Cafe cafe)
        {

            bool x = false;

            for (int i = 0; i < cafe.ListVisitorsCafe.Count; i++)
            {                
                if ((visitor.nameVisitor.Equals(cafe.ListVisitorsCafe[i].nameVisitor))          // Посетитель забронировал столик?
                && (visitor.favoriteCafe.Equals(cafe.cafeName)))                                // Посетитель является постоянным клиентом?
                {
                Console.WriteLine($"Посетитель {visitor.nameVisitor} есть в списке тех кто забронировал столик, поэтому успешно сделал заказ и получил скидку как постоянный клиент в кафе {cafe.cafeName}");
                x = true;
                    break;
                }
                               
                if (visitor.nameVisitor.Equals(cafe.ListVisitorsCafe[i].nameVisitor))           // Посетитель забронировал столик?
                {
                Console.WriteLine($"Посетитель {visitor.nameVisitor} есть в списке тех кто забронировал столик, поэтому успешно сделал заказ в кафе {cafe.cafeName}");
                x = true;
                    break;
                }                 
            }
            if (x == false)                                                                     // Посетитель не забронировал столик/
            {
                Console.WriteLine($"Посетитель {visitor.nameVisitor} не забронировал столик и его заказ в кафе {cafe.cafeName} не выполнен");
            }
        }            


        }
        
    }

