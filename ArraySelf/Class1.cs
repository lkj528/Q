using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ArrayTest
{

    static void Main()
    {


        int[][] arr = new int[2][];

        arr[0] = new int[5] { 1, 3, 5, 7, 9 };
        arr[1] = new int[4] { 2, 4, 6, 8 };


        for (int i = 0; i < arr.Length; i++)
        {

            System.Console.Write("O");
            for (int j = 0; j < arr[i].Length; j++)
            {
                System.Console.Write("O");
            }


            System.Console.WriteLine();
        }

        System.Console.WriteLine("Press any key to exit");
        System.Console.ReadKey();

    }


}