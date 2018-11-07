
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;



   class Program
    {

        private static int count = 0;
        public static EventWaitHandle waitHandle;


        static void Main(string[] args)
        {
            Console.Write("1:AutoResetEvent \n2:ManualResetEvent \n.................");
            switch( Console.ReadKey().KeyChar)
            {
                case '1':
                     waitHandle = new AutoResetEvent(true);
                    break;
                case '2':
                    waitHandle = new ManualResetEvent(true);
                    break;
            }
            Console.WriteLine("");

            Thread T1 = new Thread(new ThreadStart(DoWork));
            Thread T2 = new Thread(new ThreadStart(DoWork));

            T1.Start();
            T2.Start();

        }
        static private void DoWork()
        {
            waitHandle.WaitOne();

            for(int i = 0; i<5; i++)
            {
                Console.WriteLine(count++);
                Thread.Sleep(500);
            }
        }

       
    }

