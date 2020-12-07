using System;

namespace lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int min = 0;
            int max = 0;

            Console.WriteLine("Insert amount of elements");
            n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Insert ");
                Console.Write(i + 1);
                Console.WriteLine(" element:");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(" " + arr[i] + " ");

            }
            Console.WriteLine();

            if (n == 3)
            {
                if (arr[1] < arr[0] && arr[2] > arr[1])
                {
                    min++;
                }


            }
            else
            if (n == 3)
            {
                Console.WriteLine(" There are no elements.");
            }
            for (int i = 1;  i < (n - 1); i++)
            {
                if (n > 3)
                {
                    
                    
                        if ( arr[i - 1] > arr[i] && arr[i + 1] > arr[i] && i < (n - 1) && i > 0)
                        {
                            min++;
                        }
                        
                    

                }
                if (n == 3)
                {
                    if (arr[1] > arr[0] && arr[2] < arr[1])
                    {
                        max++;
                    }


                }

                if (n > 3)
                {
                    
                    
                        if (arr[i - 1] < arr[i] && arr[i + 1] < arr[i] && i < (n - 1))
                        {
                            max++;
                        }
                        
                    

                }
            }


            Console.WriteLine(" There is/are ");
            Console.WriteLine(min);
            Console.WriteLine("  local minimum element/elements.");
            Console.WriteLine(" There is/are ");
            Console.WriteLine(max);
            Console.WriteLine("  local maximum element/elements.");

        }
    }
}
