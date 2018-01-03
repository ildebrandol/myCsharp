using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 3, 4, 5 };
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            int[] newarr = new int[array.Length];
            for (int i = 0; i < newarr.Length; i++)
            {
                newarr[i] = array[i] + sum;
            }

            foreach(var a in newarr)
            {
                Console.WriteLine(a);
            }
            Console.ReadLine();
        }
    }
}
