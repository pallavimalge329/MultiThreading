using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace MultiThreading
{
    class Program
    {
        public static void childthread1()
        {
            Console.WriteLine("Child thread1 started");
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Child thread1 finished");
        }


        public static void childthread2()
        {
            Console.WriteLine("Child thread2 started");
            for (int i = 11; i <= 15; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Child thread2 finished");
        }


        static void Main(string[] args)
        {
            ThreadStart Child1 = new ThreadStart(childthread1);
            ThreadStart Child2 = new ThreadStart(childthread2);
            Console.WriteLine("Main Begins here");
            Thread th1 = new Thread(Child1);
            Thread th2 = new Thread(Child2);
            th1.Priority = ThreadPriority.Highest;
            th2.Priority = ThreadPriority.Lowest;
            th1.Start();
            th2.Start();
            Console.ReadKey();
        }
    }
}


