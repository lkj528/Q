using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericExample
{



    public class Generic<T, V>
    {
        private T t;
        private V v;


        int top = 0;
        int top2 = 0;
        int[] ar = new int[10];
        string[] ar2 = new string[10];

        public void SetValue(T value)
        {
            t = value;
        }

       public T GetValue()
        {
            return t;
       }
       public void SetValue2(V value2)
       {
           v = value2;
       }
       public V GetValue()
       {
           return v;
       }


         public void Push(int value)
         {
             ar[top] = value;
             top++;
         }
         public int Pop()
         {
             top--;
             return ar[top];
         }

         public void Push(string value2)
         {
             ar2[top2] = value2;
             top++;
         }
         public string pop()
         {
             top2--;
             return ar2[top2];
         }

        /* public void Push(string value)
         {
             ar3[top2] = value;
             top++;
         }
        public string Pop2()
        {
            top2--;
            return ar3[top];
        }
        */

        // public void Push(string value){
        //     ar[top]=value;
        // top++;




    }



    /*class Stack1
    {
        int top = 0;
        int[] ar = new int[10];

        public void Push(int obj)
        {
            ar[top] = obj;
            top++;
        }

        public int Pop()
        {
            top--;
            return ar[top];
        }
    }



    class Stack2
    {
        int top = 0;
        string[] ar = new string[10];

        public void Push(string obj)
        {
            ar[top] = obj;
            top++;
        }

        public string Pop()
        {
            top--;
            return ar[top];
        }
    }*/

    class StackTest
    {
        static void Main()
        {
           

            Generic<int, string> s3 = new Generic<int, string>();
            s3.Push(1);
            s3.Push(2);
            s3.Push(3);

            s3.Push("야호");
            s3.Push("된다");
            s3.Push("한글!");
            Console.WriteLine(s3.Pop());
            Console.WriteLine(s3.Pop());
            Console.WriteLine(s3.Pop());
            Console.WriteLine(s3.Pop());
            Console.WriteLine(s3.Pop());
            Console.WriteLine(s3.Pop());


        }
    }

}
    

