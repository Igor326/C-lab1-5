using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task 1
            int task1 = 123;
            Console.WriteLine("Task 1:");
            Console.WriteLine(task1.Reverse());
            // Task 2
            string task2 = "test";
            Console.WriteLine("Task 2:");
            Console.WriteLine(task2.Reverse());
            // Task 3
            double task3 = 13.237;
            Console.WriteLine("Task 3:");
            Console.WriteLine(Convert.ToDouble(task3.SplitReverse()));
            // Task 4
            string task4 = "Hello, World!";
            Console.WriteLine("Task 4:"  );
            Console.WriteLine(task4.SplitReverse());
            // Own variant(2) task
            int[] variantTask = { 1, 23, 45, 0, -12, 77 };
            Console.WriteLine("Task 5:");
            variantTask.SortDecsOrderArr();
        }
    }
}
