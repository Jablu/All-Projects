using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace MultiThreading
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            MyTask task = new MyTask();

            Console.WriteLine("mAIN tHREAD sTARETED");

            ThreadStart ts1 = new ThreadStart(task.Task1);
            Thread t1 = new Thread(ts1);

            ThreadStart ts2 = new ThreadStart(task.Task2);
            Thread t2 = new Thread(ts2);

            t1.Start();
            t2.Start();


            
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Task 1 : Instance - " + i);
                Thread.Sleep(1000);
            }
            Console.WriteLine("Thread 1 Ends");




            Console.ReadLine();
        }
    }

    class MyTask
    {
        public void Task1()
        {




            Console.WriteLine("Thread 1 Starts");
            for (int i = 1; i <= 10; i++) {
                Console.WriteLine("Task 1 : Instance - "+i);
                Thread.Sleep(1000);
            }
            Console.WriteLine("Thread 1 Ends");
        }
        public void Task2()
        {
            Console.WriteLine("Thread 2 Starts");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Task 2 : Instance - " + i);
                Thread.Sleep(1000);
            }
            Console.WriteLine("Thread 2 Ends");
        }
    }

}
