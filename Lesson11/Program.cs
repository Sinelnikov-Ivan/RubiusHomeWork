using System.IO;
using System.IO.Compression;

namespace Lesson11
{
    internal class Program
    {
        async static Task Main(string[] args)
        {

            var writeToCSVFileTask = writeToCSVFileAsync();
            var readCSVFileTask = readCSVFileAsync();

            await writeToCSVFileTask;
            await readCSVFileTask;

            async Task writeToCSVFileAsync()
            {
                await Task.Run(() => writeToCSVFile());
            }

            async Task readCSVFileAsync()
            {
                await Task.Run(() => readCSVFile());
            }

            void writeToCSVFile()
            {
                string currentDirectory = Environment.CurrentDirectory;
                while (!File.Exists(currentDirectory + "\\MyZIPFile.zip"))
                {
                    Console.WriteLine("Поток 1:    MyZIPFile.zip" + " отсутствует в папке " + currentDirectory);
                    Thread.Sleep(3000);
                }               
                
                string pathToTxtFile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\AppData\\Lesson11_Homework.txt";
                string pathToCSVFile = Environment.CurrentDirectory + "\\MyCSVFile.csv";
                
                File.Delete(pathToTxtFile);
                File.Delete(pathToCSVFile);
                ZipFile.ExtractToDirectory(Path.GetFullPath("MyZIPFile.zip"), "UnZipDir");
                using var filestreamCSV = new FileStream(pathToCSVFile, FileMode.CreateNew);
                using var streamwriterCSV = new StreamWriter(filestreamCSV);
                DirectoryInfo di = new DirectoryInfo(currentDirectory + "\\UnZipDir");
                foreach (DirectoryInfo dir in di.GetDirectories())
                {
                    streamwriterCSV.Write("Папка \t" + dir.Name + "\t" + dir.LastWriteTime + "\t");
                }
                foreach (FileInfo file in di.GetFiles())
                {
                    streamwriterCSV.Write("Файл \t" + file.Name + "\t" + file.LastWriteTime + "\t");
                }
                Directory.Delete(currentDirectory + "\\UnZipDir", true);
                using var filestreamTXT = new FileStream(pathToTxtFile, FileMode.CreateNew);
                using var streamwriterTXT = new StreamWriter(filestreamTXT);
                streamwriterTXT.Write(pathToCSVFile);
            }

            void readCSVFile()
            {                       
                string pathToTxtFile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\AppData\\Lesson11_Homework.txt";

                while (!File.Exists(pathToTxtFile))
                {
                    Console.WriteLine("Поток 2:    Lesson11_Homework.txt отсутствует в папаке " + Environment.GetFolderPath(Environment.SpecialFolder.UserProfile));
                    Thread.Sleep(3000);
                }


                using var filestreamTXT = new FileStream(pathToTxtFile, FileMode.Open);
                using var streamReaderTXT = new StreamReader(filestreamTXT);
                string pathToCSVFile = streamReaderTXT.ReadToEnd();
                if (!File.Exists(pathToCSVFile))
                {
                    Console.WriteLine("Поток 2:    MyCSVFile.csv отсутствует");
                    Thread.Sleep(3000);
                }
                using var filestreamCSV = new FileStream(pathToCSVFile, FileMode.Open);
                using var streamReaderCSV = new StreamReader(filestreamCSV);

                string[] words = (streamReaderCSV.ReadToEnd().Split("\t"));

                for (int x = 2; x < words.Length; x += 3)
                {
                    var valueDate = DateTime.Parse(words[2]);
                    int minIndex = 2;

                    for (int i = 2; i < words.Length; i += 3)
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
}