using System.Threading;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ThreadTest2
{
    bool sleep = false;

    static AutoResetEvent autoEvent = new AutoResetEvent(false);


    public void FirstWork()
    {
        for (int i = 0; i < 10; i++)
        {
            Thread.Sleep(1000);
            Console.WriteLine("F{0}", i);
            if (i == 5)
            {
                sleep = true;
                Console.WriteLine("");
                Console.WriteLine("first rest");
                autoEvent.WaitOne();
            }
        }
    }




    
        static void Main(string[] args)
        {
        ThreadTest2 t = new ThreadTest2();
        Thread first = new Thread(new ThreadStart(t.FirstWork));
        first.Start();
        while (t.sleep == false) { }
        Console.WriteLine("wake up first 2sec later");
        Thread.Sleep(2000);
        autoEvent.Set();
        }
    
}