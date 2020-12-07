using System;
using System.Collections.Generic;

namespace lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            int c;
            int count = 0;
            List<string> ListOfStrings = new List<string>();
            string temp="Hello";
            string indx ="world";
            
            while (true)
            {
                Console.WriteLine("Введите количество переменных типа String, которые вы хотите добавить:");
                c = Convert.ToInt32(Console.ReadLine());
                if(c<=0 || c % 1 != 0)
                {
                    Console.WriteLine("Введите корректное количество переменных типа String, которые вы хотите добавить!");
                    continue;
                }
                break;
            }
            for (int i = 0; i < c; i++)
            {
                Console.WriteLine("Введите {0}-й элемент:" , i+1);
                temp = Convert.ToString(Console.ReadLine());
                ListOfStrings.Add(temp);
                
            }
            Console.WriteLine("Ваш список:");
            for (int i = 0; i < c; i++)
            {
                Console.WriteLine(ListOfStrings[i]);
               

            }
           
                Console.WriteLine("Введите значение переменной для поиска одинаковых переменных:");
                indx = Convert.ToString(Console.ReadLine());
            for (int i = 0; i < c; i++)
            {
                if (ListOfStrings[i] == indx)
                {
                    Console.WriteLine("Была найдена аналогичная переменная с индексом {0}", i);
                    count++;
                }

            }
            if (count == 0)
            {
                Console.WriteLine("Совпадений не найдено");
            }
            c = ListOfStrings.Count;
             string[] arr=new string [c];
            for (int i = 0; i < c; i++)
            {
                arr[i] = ListOfStrings[i];

            }

            Console.WriteLine("Ваш массив:");
            for (int i = 0; i < c; i++)
            {
                Console.WriteLine("[{0}] ", arr[i]);

            }
        }
    }
}
