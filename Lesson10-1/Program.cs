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
            string PathToTxtFile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\AppData\\Lesson10_Homework.txt";
            string PathToCSVFile = currentDirectory + "\\MyCSVFile.csv";
            File.Delete (PathToTxtFile);
            File.Delete (PathToCSVFile);
            ZipFile.ExtractToDirectory (pathToZipFile, "UnZipDir");         
            using var filestreamCSV = new FileStream (PathToCSVFile, FileMode.CreateNew);
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
            using var filestreamTXT = new FileStream(PathToTxtFile, FileMode.CreateNew);
            using var streamwriterTXT = new StreamWriter(filestreamTXT);
            streamwriterTXT.WriteLine(PathToCSVFile);           
        }
    }
}