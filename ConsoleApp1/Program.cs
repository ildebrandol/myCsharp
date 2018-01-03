using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        class Flower
        {
            public string name;
            public Flower(string _name)
            {
                name = _name;
            }

            public string GetName()
            {
                return name;
            }

            public static int Sum(int a, int b)
            {
                return a + b;
            }
        }

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

            Flower rose = new Flower("flower1");
            Console.WriteLine(rose.GetName());

            Console.WriteLine(Flower.Sum(1, 2));
            Console.ReadLine();
        }
    }
}
