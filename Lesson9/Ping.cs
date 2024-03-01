using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_9
    {
    internal class Ping
    {
        delegate void MyDeligate();
        public static void DoPing()
        {
            MyDeligate GoToPong = Pong.DoPong;

            Random rnd = new Random();
            int value = rnd.Next(0, 100);

            if (value == 0)
            {
                Console.WriteLine("Ping промахнулся! Победил Pong");
            }
            else
            {
                Console.WriteLine("Pong получил Ping");
                GoToPong();
            }                         
        }
    }
}
