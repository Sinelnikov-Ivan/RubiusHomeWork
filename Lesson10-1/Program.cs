using System.IO.Compression;

namespace Lesson10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string currentDirectory = Environment.CurrentDirectory;
            string pathToZipFile = Path.GetFullPath("MyZIPFile.zip");
            string unZipDirectory = currentDirectory + "\\UnZipDir";
            string pathToTxtFile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\AppData\\Lesson10_Homework.txt";
            string pathToCSVFile = currentDirectory + "\\MyCSVFile.csv";
            File.Delete (pathToTxtFile);
            File.Delete (pathToCSVFile);
            ZipFile.ExtractToDirectory (pathToZipFile, "UnZipDir");         
            using var filestreamCSV = new FileStream (pathToCSVFile, FileMode.CreateNew);
            using var streamwriterCSV = new StreamWriter (filestreamCSV);            
            DirectoryInfo di = new DirectoryInfo(unZipDirectory);
            foreach (DirectoryInfo dir in di.GetDirectories())
            {
                streamwriterCSV.WriteLine ("Папка \t" + dir.Name + "\t" + dir.CreationTime);  
            }
            foreach (FileInfo file in di.GetFiles())
            {
                streamwriterCSV.WriteLine ("Файл \t" + file.Name + "\t" + file.CreationTime);
            }
            Directory.Delete(unZipDirectory, true);
            using var filestreamTXT = new FileStream(pathToTxtFile, FileMode.CreateNew);
            using var streamwriterTXT = new StreamWriter(filestreamTXT);
            streamwriterTXT.WriteLine(pathToCSVFile);           
        }
    }
}