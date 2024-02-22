using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5 
{
    public class Doctor
    {
        private string name;
        private int age;
        private string specialization;
        private int cureSuccess;
        private int cureFailure;          

        public Doctor (string name, int age, string specialization,  int cureSuccess, int cureFailure)
        {
            this.age = age;
            this.name = name;
            this.specialization = specialization;
            this.cureSuccess = cureSuccess;
            this.cureFailure = cureFailure;                   
        }

        public void Cure (Patient patient)
        {
            Random rnd = new Random();
            var randomCure = rnd.Next(0, 2);
            if (patient.disease == false)
            {
                Console.WriteLine($"Пациенту {patient.name} лечение не требуется, пациент здоров!");
                return;
            }

            if (randomCure ==1) 
            {
                Console.WriteLine("Врач начал лечение...");
                Console.WriteLine ($"Врач {name} успешно вылечил пациента! {patient.name} ");
                patient.disease = false;
                cureSuccess++;
            } 
            else
            {
                Console.WriteLine("Врач начал лечение...");
                Console.WriteLine($"Врач {name} не смог вылечить пациента {patient.name} ");
                cureFailure++;
            }
        }
        public void IntroduceYourself()
        {
            Console.WriteLine("Врач:");
            Console.WriteLine($"Меня зовут {name}, я врач, мне {age} лет, моя специализация {specialization}.");
            Console.WriteLine($"Успешно вылечил {cureSuccess} человек, не вылечил {cureFailure} человек.");
        }  
    }
}
