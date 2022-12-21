using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Compression;

namespace laba12
{
    static class YNSFileManager
    {
        private static string _path = YNSLog.Path;
        private static string _nameDisk;
        public static string NameDisk
        {
            set { _nameDisk = value; }
        }
        public static void Z5a(string nameDisk)
        {
            DriveInfo drive = new DriveInfo(nameDisk);
            if (drive == null)
            {
                throw new Exception("No path to file.");
            }
            File.AppendAllText(_path, $"{DateTime.Now} Выполнение задания Z5A\n");

            var listFiles = Directory.GetFiles(nameDisk);
            var listCat = Directory.GetDirectories(nameDisk);

            Directory.CreateDirectory(nameDisk + "\\YNSInspect");
            File.AppendAllText(nameDisk + "\\YNSInspect\\YNSdirinfo.txt", "Файлы: ");
            foreach (var a in listFiles)
            {
                File.AppendAllText(nameDisk + "\\YNSInspect\\YNSdirinfo.txt", a + " ");
            }
            File.AppendAllText(nameDisk + "\\YNSInspect\\YNSdirinfo.txt", "\nДиректории: ");
            foreach (var a in listCat)
            {
                File.AppendAllText(nameDisk + "\\YNSInspect\\YNSdirinfo.txt", a + " ");
            }
            File.Copy(nameDisk + "\\YNSInspect\\YNSdirinfo.txt", nameDisk + "\\YNSInspect\\YNSdirinfo2.txt");
            File.Delete(nameDisk + "\\YNSInspect\\YNSdirinfo.txt");
        }
        public static void Z6b(string directory)
        {
            if (!Directory.Exists(directory))
            {
                throw new Exception("No path to file.");
            }
            File.AppendAllText(_path, $"{DateTime.Now} Выполнение задания Z5b\n");
            int size = 0;
            Directory.CreateDirectory("C:\\YNSFiles");
            foreach (var file in Directory.GetFiles(directory))
            {
                if ((new FileInfo(file)).Extension == ".pdf")
                {
                    string pth = $"C:\\YNSFiles\\copy{size++}.pdf";
                    (new FileInfo(file)).CopyTo(pth);
                }
            }
            (new DirectoryInfo("C:\\YNSFiles")).MoveTo("D:\\YNSInspect2"); 
        }
        public static void Z6c(string nameFolder)
        {
            File.AppendAllText(_path, $"{DateTime.Now} Выполнение задания Z5c\n");
            string oath = Path.GetDirectoryName(nameFolder);
            ZipFile.CreateFromDirectory(nameFolder, oath + "MyZip.zip");

            ZipFile.ExtractToDirectory(oath + "MyZip.zip", oath + "MyZipFolder");
        }
    }
}
