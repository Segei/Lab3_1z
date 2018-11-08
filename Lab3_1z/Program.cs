using System;

namespace Lab3_1z
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[] mass = new int[20];
            int f=0;
            for (int i = 0; i < 20; i++)
            {
               
                mass[i]=rand.Next(-10, 10);
                Console.WriteLine(mass[i]);
            }
            for(int i = 0; i < 20; i++)
            {
                if (mass[i] > 0)
                {
                    f++;
                }
            }
            Console.WriteLine("Положительных чисел: " + f);
            Console.ReadKey();
        }
    }
}
