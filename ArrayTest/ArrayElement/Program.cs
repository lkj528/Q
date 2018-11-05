using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayElement
{
    class Program
    {
        static void Main()
        {

            string[] array = new string[2];
            array[0] = "가";
            array[1] = "나";

            for (int i = 0; i < array.Length; i++)
            {
                string element = array[i];
                Console.WriteLine(element);
               
            }

            Console.WriteLine();
            foreach (string element in array)
            {

                Console.WriteLine(element);
            }
        }
    }
}
