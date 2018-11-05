using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLength
{
    class Program
    {
        static void Main()
        {


            string[] arr = new String[]
                {

        "가","나","다","라"
        };

            Console.WriteLine(arr[arr.Length - 1]);
            Console.WriteLine(arr[arr.GetLength(0) - 1]); //GetLength는 문자열 길이 함수
        }
    }
}
