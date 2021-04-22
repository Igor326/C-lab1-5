using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            ///////////1.
            var directory = new DirectoryInfo(@"E:\LAB7");
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
                string name = "Folder_" + i;
                directory.CreateSubdirectory(name);

                
            }
            Console.WriteLine("Папки создались.");
            Console.ReadKey();
            for (int i = 0; i < 100; i++)
            {
                string name = "Folder_" + i;
                string fullName = "E:\\LAB7\\"+ name;
                Directory.Delete(fullName, true);


            }
            Console.WriteLine("Папки удалились.");
            Console.ReadKey();
            
            

        }
    }
}
