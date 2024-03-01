using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_9
{
    internal class Pong
    {
        delegate void MyDeligate(); 
        public static void DoPong()
        {
            MyDeligate GoToPing = Ping.DoPing;

            Random rnd = new Random();
            int value = rnd.Next(0, 100);

            if (value == 0)
            {
                Console.WriteLine("Pong промахнулся! Победил Ping");
            }
            else
            {
                Console.WriteLine("Ping получил Pong");
                GoToPing();
            }
        }
    }
}

