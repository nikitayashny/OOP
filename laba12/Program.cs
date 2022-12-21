namespace laba12
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                YNSLog.Path = "C:\\Users\\User\\Desktop\\ООП\\laba12\\laba12\\ynslogfile.txt";

                YNSDiskInfo.FreeMemory();
                YNSDiskInfo.WriteFileSystem();
                YNSDiskInfo.WriteGlobalInf();

                YNSFileInfo.PathToFile = "C:\\Users\\User\\Desktop\\ООП\\задания\\12_Потоки_файловая система.pdf";
                YNSFileInfo.WriteFullPath(); 
                YNSFileInfo.WriteFulInf();
                YNSFileInfo.WritrDopInf();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
