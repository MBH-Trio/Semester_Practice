using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Directory
{
    class Program
    {
        static void Main(string[] args)
        {
            //DirectoryInfo dir_info = new DirectoryInfo("d:/semester 5");
            //DirectoryInfo dir_info = new DirectoryInfo("d:/new_code");
            DriveInfo driveInfo = new DriveInfo("C");
            Console.WriteLine( driveInfo.ToString());
            
            DirectoryInfo dir_info = new DirectoryInfo("d:");


            if (!dir_info.Exists) // if drive or file does not exists
            {
                //dir_info.Create();
                return;
            }
            //dir_info.Delete();
            //Console.WriteLine("delete is called");
            


            //Console.WriteLine("dir_info.GetAccessControl() : " + dir_info.GetAccessControl().ToString());
            int i = 0;
            Console.WriteLine("the dir info method to get all the directories");
            foreach(DirectoryInfo dir in dir_info.GetDirectories())
            {
                Console.WriteLine(i++ + " "+dir.ToString());
            }
            Console.WriteLine("the dir info method to get all the Files\n");
            foreach (FileInfo dir in dir_info.GetFiles())
            {
                Console.WriteLine(i++ +" " + dir.ToString());
            }
            Console.WriteLine("the dir info method to get all the Files with the patttern \n");
            foreach (FileInfo dir in dir_info.GetFiles("*.txt"))
            {
                Console.WriteLine(i++ + " " + dir.ToString());
            }


            

            //Console.WriteLine("extension "+ dir_info.Extension.ToString());
            Console.WriteLine("dir_info.LastAccessTime " + dir_info.LastAccessTime);

            Console.WriteLine("dir_info.name " + dir_info.Name);
            Console.WriteLine("dir_info.parent" + dir_info.Parent);
            Console.WriteLine("dir_info.root " + dir_info.Root);


            FileInfo file = new FileInfo("d:/test.txt");
            if(file.Exists)
            {
                Console.WriteLine(file.ToString());
                Console.WriteLine(file.GetAccessControl().ToString());
                Console.WriteLine(file.Name);
                
                Console.WriteLine("the extension is "+file.Extension.ToString());
                Console.WriteLine((file.Attributes).ToString());
                String data = "";
                
                StreamReader reader =  file.OpenText();
                Console.WriteLine("the data in the file is : ");
                while ( (data = reader.ReadLine()) !=null)
                {
                    Console.WriteLine(data);
                }
                reader.Close();
                
            }
            else
            {
                Console.WriteLine("file does not exists");
            }


            Console.WriteLine(file.ToString());

            FileInfo file_1 = new FileInfo("d:/test.txt");
            if(file_1.Exists)
            {
                file_1.MoveTo("d:/Semester 1/ok.txt");

            }
            string ok = "this";
            ok.Replace('t','a');




        }
    }
}
