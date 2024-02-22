using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    public class Patient 
    {
        public string name;
        public int age;
        public bool disease;

        public Patient (string name, int age, bool disease)
        {
            this.name = name;
            this.age = age;
            this.disease = disease;
        }

        public void SelfCure ()
        {
            Random rnd = new Random();
            var randomCure = rnd.Next(0, 2);

            if (disease == false)
            {
                Console.WriteLine($"{name} начал самолечение:");
                Console.WriteLine($"но ему лечение не требуется, он здоров!");
                return;
            }

            if (randomCure == 1)
            {
                Console.WriteLine($"{name} начал самолечение");
                Console.WriteLine($"и успешно вылечил сам себя");
                disease = false;                
            }
            else
            {
                Console.WriteLine($"{name} начал самолечение:");
                Console.WriteLine($"и не смог вылечить сам себя");                
            }
        }

        public void IntroduceYourself()
        {   if (disease == false)
            {
                Console.WriteLine("Пациент:");
                Console.WriteLine($"Меня зовут {name}, мне {age} лет и я здоров.");
                }
           else {
                Console.WriteLine("Пациент:");
                Console.WriteLine($"Меня зовут {name}, мне {age} лет и я болею.");
            }                       
        }
    }
}
