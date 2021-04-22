using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lab7_2
{
    class Program
    {
        static void Main(string[] args)
        {

            var directory = new DirectoryInfo(@"E:\LAB7");
            string fullName="";

            if (directory.Exists)
            {
                Console.WriteLine("Директория существует.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Директория HE существует.");
                Console.ReadKey();
            }
            for (int i = 0; i < 100; i++)
            {
                string name= "Folder_" + i+"\\";
                fullName += name;
 
            }
            directory.CreateSubdirectory(fullName);
            Console.WriteLine("Папки создались.");
            Console.ReadKey();
            Directory.Delete(@"E:\LAB7\Folder_0",true);
            Console.WriteLine("Папки удалились.");
            Console.ReadKey();
            //Console.WriteLine(fullName);
            //4.Максимальна довжина ім'я папки  - 247 символів

        }
    }
}
