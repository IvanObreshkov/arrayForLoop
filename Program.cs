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
            /*
            foreach (int item in array) //this loop gets out of index bounds and i dont even know why help
            {
                array[item] = 1;
                Console.WriteLine(array[item]);
            }*/
            
            //Time for explanation
            /*
              The iteration variable "item" usually is an Object and Objects in C# are immutable you can read more about
              this here: https://stackoverflow.com/questions/776430/why-is-the-iteration-variable-in-a-c-sharp-foreach-statement-read-only
              https://kodify.net/csharp/loop/foreach-read-only/
              https://social.msdn.microsoft.com/Forums/vstudio/en-US/a90c87be-9553-4d48-9892-d482ee325f02/why-cant-change-value-in-foreach?forum=csharpgeneral
              
              The foreach loop is most commonly used to iterate over the elements of a collection.
              It your case you are trying to set the value 1 to an item in the array with index "item". But item has a 
              different behaviour compared to regular variables (the index must be an integer, and item is not a regular one
              also it doesnt have a value such as 1 or 5), so that's why you cannot change it.
              https://www.geeksforgeeks.org/c-sharp-foreach-loop/
              https://www.programiz.com/csharp-programming/foreach-loop
              
              If you want to change a particular item in the array you must use for loop as "i" is the position of the 
              element. (That will change every item in the array as i is increasing in value and moving to the next position.
              If you want to change only a specific item you can do it like this: array[index] = something;

             */

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = 1; //Every element of the array will become 1. If you put in debug mode
                //you will see array[0] = 1;
                //array[1] = 1;
                //array[2] = 1 and so on
                Console.WriteLine(array[i]);
            }
        }
    }
}
