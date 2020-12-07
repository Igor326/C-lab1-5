using System;

namespace lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int a;
            int Sgol=0;
            int Spob=0;
            Console.WriteLine("Insert amount of lines and rows:");
            int l = Convert.ToInt32(Console.ReadLine());
            int r = l;
            int[,] ar = new int[l, r];
            for (int i=0;i<l;i++)
            {
                for (int j=0;j<r;j++)
                {
                    ar[i,j] = rnd.Next(0, 10);
                }
            }
            for (int i = 0; i < l; i++)
            {
                for (int j = 0; j < r; j++)
                {
                    Console.Write(" [" + ar[i, j] + "] ");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < l; i++)
            {

                Sgol += ar[i, i];
                
               
            }
            Console.WriteLine("Sum of the main diagonal is "+Sgol);
            for (int i = 0; i < l; i++)
            {
                Spob += ar[i, l - 1 - i];
                
            }
            Console.WriteLine("Sum of the side diagonal is " + Spob);

        }


    }
}
