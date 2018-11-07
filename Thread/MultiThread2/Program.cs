using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;



namespace MultiThread2
{
    
    class Program
    {

        public static Thread sleeperThread;
        public static void Main(string[] args)
        {
            sleeperThread = new Thread(new ThreadStart(ThreadToSleep));
            sleeperThread.Start();
            sleeperThread.Interrupt();
        }



        private static void ThreadToSleep()
        {
            int i = 0;
            while(true)
            {
                Console.WriteLine("[Sleeper: " + i++ + "]");
                if(i==9)
                {
                    try
                    {
                        Console.WriteLine("i = 9 가 되어 3초 쉼");
                        Thread.Sleep(3000);

                    }
                    catch(ThreadInterruptedException e)
                    {
                        Console.WriteLine("쓰레드 예외발생");
                        Environment.Exit(0);
                    }
                }
            }
        }
    }
}
 