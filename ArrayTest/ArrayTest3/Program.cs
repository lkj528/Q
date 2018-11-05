using System;
namespace ConsoleApplication3
{

    class Program
    {
        static void Main(string[] args)
        {

            int[][] a = { new int[]{1,2},new int[]{1,2,3},new int[]{1,2,3,4}};

            int[,] b = { {1,2}, {3,4}, {5,6}};





            for(int i=0; i<a.Length;i++)
            {
                foreach ( int j in a[i])
                {
                    Console.Write(j+ " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n --------------------- \n");
            
                foreach ( int j in b )
                {
                    Console.Write(j + " ");
                }


                 Console.WriteLine();
            
        }
    }
}


























