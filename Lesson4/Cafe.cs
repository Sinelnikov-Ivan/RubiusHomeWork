using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    public class Cafe
    {      
        public string cafeName;
        public List<Visitors> ListVisitorsCafe = new List <Visitors>();

        public Cafe(string _Name) 
        {
            cafeName = _Name;  
        }

        public void BookTable (Visitors visitor)  // Бронируем столик  
        {
            ListVisitorsCafe.Add (visitor);
            Console.WriteLine($"В список клиентов кафе {cafeName} добавлен посетитель {visitor.nameVisitor}" );
        }

    }
}
