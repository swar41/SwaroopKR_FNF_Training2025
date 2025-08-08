using System;
using System.Threading;

namespace SampleConsoleApp1
{
    /* technique which helps in executing the multiple threads concurrently
     * thread is path of execution within process. Process will have atleast one thread which is main thread.
     * Threads in .NET are objects of the System.Threading.Thread class. It takes a delegate as a parameter to the constructor, which is the functionality that will be executed in the new thread.
     * ThreadStart is the name of the delegate that is used to create a thread. It does not take any parameters and does not return any value.
     * However, for passing parameters to the thread, we can use ParameterizedThreadStart delegate. The parameter will always be object type, so we need to cast it to the required type inside the thread function. With multiple Threads, U must handle the synchronization of data between threads.
     */
    internal class ex24MultiThreading
    {
        static void SomeComplexOperation()
        {
            lock (typeof(ex24MultiThreading))
            { //Locking the class type to ensure only one thread can access this method at a time
                var currentthread = Thread.CurrentThread;
                int count = 0;

                Console.WriteLine("Complex operation");
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine($"Complex function running at count {count} and thread num{currentthread.Name}");
                    count++;
                    Thread.Sleep(1000); //Simulating a complex operation by sleeping for 1 second
                }
                Console.WriteLine("exiting Complex operation");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Main Function");
            //SomeComplexOperation();
            Thread t1 = new Thread(SomeComplexOperation); //Assigning the method to the ThreadStart delegate
            t1.Start();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Main function running");
                Thread.Sleep(1000); //Simulating a complex operation by sleeping for 1 second
            }
            Console.WriteLine("operation doneee!!!");
        }
    }
}
