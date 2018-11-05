using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayTest4
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] twoDim = { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };


            Console.WriteLine(twoDim.Length);

            for (int j = 0;  ; )
            {



                for (int i = 0; i < twoDim.Length; i++)
                {




                    Console.Write(twoDim[i, j]);

                }




                //     Console.Write(twoDim[i, j]);
                //}

                // foreach (int a in twoDim[1])
                //  {
                //     Console.Write(a);

                // }

                //for (j = 0; j <twoDim[i,j].Length; j++)
                //{





                //     Console.Write(twoDim[i, j]);
            }

            


        }
    }
    
}
