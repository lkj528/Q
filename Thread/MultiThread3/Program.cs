using System.Threading;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiThread3
{

    public class ThreadTest2
    {
        bool sleep = false;

        static AutoResetEvent autoEvent = new AutoResetEvent(false);


        public void FirstWork()
        {
            for (int i =0; i <10; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine("F{0}", i);

                if (i == 5)
                {
                    sleep = true;
                    Console.WriteLine("");
                    Console.WriteLine("first sleep");
                    autoEvent.WaitOne();
                }
            }
            
        
        }
        public static void Main()
        {
            ThreadTest2 t = new ThreadTest2();
            Thread first = new Thread(new ThreadStart(t.FirstWork));
            first.Start();
            while (t.sleep == false) { }
            Console.WriteLine("woke up first");
            Thread.Sleep(2000);
            autoEvent.Set();
        }
    }
    
}
