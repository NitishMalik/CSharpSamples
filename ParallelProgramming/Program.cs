using System;
using System.Threading;
using System.Threading.Tasks;

namespace ParallelProgramming
{
    class Program
    {
        private const string Value = "Thanos the main programmer";

        static void Main(string[] args)
        {

            //// Global Mutex
            //Mutex mutex;
            //try
            //{
            //    mutex = Mutex.OpenExisting("Nitish");
            //    Console.WriteLine("Sorry , app already running...");
            //}
            //catch (WaitHandleCannotBeOpenedException ex)
            //{
            //    Console.WriteLine("Grabing mutex and running the app");
            //    mutex = new Mutex(true, "Nitish");
            //}

            //Console.ReadKey();
            //mutex.ReleaseMutex();


            // --Usage of TaskInfo class --
            //// TaskInfo taskInfo = new TaskInfo();
            //// taskInfo.CreateCancellableTask();
            //// taskInfo.ExceptionHandling();

            //Synchronization sync = new Synchronization();
            //// sync.SynchronizeCheck();
            //sync.SynchronizeCheckWithMutex();


            //Console.WriteLine(Value);

            // --Usage of ConcurrentDic class --
            //ConcurrentDic dic = new ConcurrentDic();
            //dic.PrintRecords();

            // --Usage of Blocking Collection class --
            BlockingColl bc = new BlockingColl();
            bc.StartProcess();

            Console.ReadLine();
            bc.CancelTask();
            Console.ReadLine();

        }


    }
}
