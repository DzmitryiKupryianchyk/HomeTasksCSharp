using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionForArray
{
    static class ArrayExtension
    {
        public static void EXT(this int[] myArray) 
        {
            int max = 0;
            foreach (int i in myArray) 
            {
                if (i > max) 
                {
                    max = i;
                }
            }
            Console.WriteLine(max);
            //Console.WriteLine(myArray.Max());
        }
        public static void EXT1(this string[] myArray1)
        {
            List<int> myList = new List<int>(); 
            foreach (var i in myArray1) 
            {
                int a = int.Parse(i);
                myList.Add(a);
            }
            Console.WriteLine(myList.Max());
        }
    }
}
