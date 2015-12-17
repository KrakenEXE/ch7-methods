using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _10
{
    class Program
    {
        static void Main(string[] args)
        {
            //establish arrays
            int[] array1 = { 0, 1, 2, 3, 4 };
            int[] array2 = { 0, 1, 2, 3, 4, 5, 6 };
            int[] array3 = { 0, 1, 2, 3, 4, 5, 6 , 7, 8};
            //send arrays to method 
            addArrays(array1);
            addArrays(array2);
            addArrays(array3);
            WriteLine("Click enter to exit...");
            ReadLine();
        }
        private static void addArrays(int[] array)
        {
            //establish array sum variable
            int arraySum = 0;
            //write array loop to count array length and add them together with +=
            for (int x = 0; x < array.Length; ++x)
            {
                WriteLine(array[x]);
                arraySum += array[x];
            }
            //print out array sum and the arrays numbers
            WriteLine("\n SUM >> "+arraySum+"\n");
        }
        
    }
}
