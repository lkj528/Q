using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic2
{
    class MyArray<T>
    {

        private T[] onj;

        public MyArray(int size)
    {
        onj = new T[size];
    }


        public void SetElement(int index, T value)
        {
            onj[index] = value;
        }

        public T GetElement(int index, T value)
        {
            return onj[index];
        }

        public void PrintElements()
        {
            foreach (T o in onj)
            {
                Console.WriteLine(o);
            }
        }
    }

        class MainApp
        {
            public static void Main(string[] args)
            {
                MyArray<string> array = new MyArray<string>(4);
                array.SetElement(0, "OnjOracleJava");
                array.SetElement(1, "OracleJava Community");
                array.SetElement(2, "OnjProgramming.co.kr");
                array.SetElement(3, "oraclejavanew.kr");
                array.PrintElements();
                

            }

        




    }
}
