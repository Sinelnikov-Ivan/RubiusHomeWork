using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8
{
    public class Counter 
    {
        public delegate void myDeligate ();
        public event myDeligate? myEvent;

         public void startCounter ()          
        {                     
            for (int i = 1; i < 100; i++)
            {
                Console.WriteLine(i);
                if (i == 77)
                {
                    myEvent.Invoke();
                }
            }
        }
    }
}
