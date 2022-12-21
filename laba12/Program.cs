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

                YNSDirInfo.PathToDirectory = "C:\\Users\\User\\Desktop\\ООП\\laba12";
                YNSDirInfo.WriteCountFile();
                YNSDirInfo.WriteTimeCreation();
                YNSDirInfo.WriteCountPodDir();
                YNSDirInfo.WriteParentDir();

                //YNSFileManager.Z5a("С:\\");
                //YNSFileManager.Z6b("С:\\Users\\User\\Desktop\\ООП\\laba12");
                //YNSFileManager.Z6c("С:\\YNSInspect2");

                using (FileStream file2 = File.Open("C:\\Users\\User\\Desktop\\ООП\\laba12\\laba12\\ynslogfile.txt", FileMode.Open, FileAccess.Read, FileShare.None))
                {
                    byte[] buff = new byte[file2.Length];
                    byte[] buff2 = new byte[file2.Length];
                    int size = 0;
                    int count = 0;
                    file2.Read(buff, 0, buff.Length);
                    for (int i = 0; i < buff.Length; i++)
                    {
                        if (buff[i] == '1' && buff[i + 1] == '3')
                        {
                            while (buff[i] != '\n')
                            {
                                buff2[size++] = buff[i++];
                            }
                            buff2[size++] = (byte)'\n';
                        }
                        if (buff[i] == '\n')
                        {
                            count++;
                        }
                    }
                    using (FileStream file = File.Create("C:\\Users\\User\\Desktop\\ООП\\laba12\\laba12\\ynslogfile2.txt"))
                    {
                        file.Write(buff2, 0, size);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
