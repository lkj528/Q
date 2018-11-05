using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayJoin
{
    class Program
    {


        static void Main()
        {
            Console.WriteLine(string.Join(" ", Method()));

        }
        static string[] Method()
        {
            string[] array = new string[2];
            array[0] = "대한민국";
            array[1] = "서울";
            return array;

        }
    }
}



