using System;

namespace lab_6_7
{
    class Program
    {
        static void ReverseArray(ref int[] arr)
        {
            for (int i = 0; i < arr.Length / 2; i++)
            {
                int c = arr[i];
                arr[i] = arr[arr.Length - i - 1];
                arr[arr.Length - i - 1] = c;
            }
        }
        static void Main(string[] args)
        {
            int val;
            Console.WriteLine("Write amount of numbers in array:");
            val= Convert.ToInt32(Console.ReadLine());
            int[] ar = new int[val];
            for (int i =0; i < val; i++){
                Console.WriteLine("arr["+i+"] =");
                ar[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < val; i++)
            {
                Console.Write("["+ar[i]+"]" + " ");
                


            }
            Console.WriteLine();
            Console.WriteLine("Reversed array:");

           ReverseArray(ref ar);
            for (int i = 0; i < val; i++)
            {
                Console.Write("[" + ar[i] + "]" + " ");



            }
            

        }
    }
}
