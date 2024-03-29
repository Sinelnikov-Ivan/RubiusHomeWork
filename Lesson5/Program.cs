﻿using System.Xml.Linq;
using static Lesson5.Doctor;

namespace Lesson5
{
    internal class Program
    {
        static void Main(string[] args)
        {     
            Doctor doctor1 = new Doctor ("Николай Сергеевич", 40, "Терапевт", 1000, 5);
            Doctor doctor2 = new Doctor ("Борис Фёдорович", 30, "ЛОР", 900, 10);
            Doctor doctor3 = new Doctor ("Святослав Иванович", 30, "Травмотолог", 400, 15);

            Patient patient1 = new Patient ("Дядя Слава", 20, true);
            Patient patient2 = new Patient ("Дядя Вася симулянт", 40, false);
            Patient patient3 = new Patient ("Дядя Стёпа", 30, true);

            patient1.IntroduceYourself();
            patient2.IntroduceYourself();
            patient3.IntroduceYourself();
                      
            patient1.SelfCure();
            patient2.SelfCure();
            patient3.SelfCure();

            doctor1.IntroduceYourself();
            doctor2.IntroduceYourself();
            doctor3.IntroduceYourself();

            doctor1.Cure(patient1);
            doctor2.Cure(patient2);
            doctor3.Cure(patient3);

            Console.ReadLine ();   

        }
    }
}