using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lesson4
{
    public class Cafe
    {      
        public string name;
        public int numberOfAvailableTabless;
        public List<Visitor> ListVisitorsCafe = new List <Visitor>();

        public Cafe(string _name, int _numberOfAvailableTabless) 
        {
            name = _name;
            numberOfAvailableTabless = _numberOfAvailableTabless;
        }

        public void BookTable (Visitor visitor)  // Бронируем столик  
        {
            if (numberOfAvailableTabless > 0)
            {

            ListVisitorsCafe.Add(visitor);
            numberOfAvailableTabless--;
            Console.WriteLine($"В список заказавших столик в кафе {name} добавлен посетитель {visitor.name}");
            }
            else
            {
            Console.WriteLine($"В кафе {name} нет свободных столиков и посетителю {visitor.name} не смог забронировать столик");

                ListVisitorsCafe.Add(visitor);
                numberOfAvailableTabless--;
                Console.WriteLine($"В список заказавших столик в кафе {name} добавлен посетитель {visitor.name}");
            }
            else
            {
                Console.WriteLine($"В кафе {name} нет свободных столиков и посетителю {visitor.name} не смог забронировать столик");

            }
        }
    }
}
