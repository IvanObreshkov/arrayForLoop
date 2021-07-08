using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];
            int m = 0;
            for (int i = 0; i < array.Length; i++)
            {
                m++;
                array[i] = m;
                Console.WriteLine(array[i]);
            }
            foreach (int item in array) //this loop gets out of index bounds and i dont even know why help
            {
                array[item] = 1;
                Console.WriteLine(array[item]);
            }
        }
    }
}
