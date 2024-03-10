using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;

namespace Lesson10_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pathToTxtFile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\AppData\\Lesson10_Homework.txt";
            if (!File.Exists (pathToTxtFile) )
            {
                throw new FileNotFoundException ("Lesson10_Homework.txt отсутствует");
            }
            using var filestreamTXT = new FileStream(pathToTxtFile, FileMode.Open);
            using var streamReaderTXT = new StreamReader(filestreamTXT);
            string pathToCSVFile = streamReaderTXT.ReadToEnd();
            if (!File.Exists(pathToCSVFile))
            {
                throw new FileNotFoundException("*.csv отсутствует");
            }
            using var filestreamCSV = new FileStream(pathToCSVFile, FileMode.Open);
            using var streamReaderCSV = new StreamReader(filestreamCSV);

            string [] words = (streamReaderCSV.ReadToEnd().Split("\t"));   

            for (int x = 2; x < words.Length; x += 3)
            {
                var valueDate = DateTime.Parse(words[2]);
                int minIndex = 2;

                for (int i = 2; i < words.Length; i+=3)
                { 
                    if (valueDate > DateTime.Parse(words[i]))
                        {
                        valueDate = DateTime.Parse(words[i]);
                        minIndex = i;
                        }                   
                }
            Console.WriteLine(words[minIndex - 2] + "\t" + words[minIndex - 1] + "\t" + words[minIndex]);
            words[minIndex] = DateTime.MaxValue.ToString();
            }
            filestreamTXT.Close();
            File.Delete(pathToTxtFile);
        }
    }
}