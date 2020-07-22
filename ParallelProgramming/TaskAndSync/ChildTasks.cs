using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ParallelProgramming
{
    public class ChildTasks
    {
        public void Print(string msg)
        {
            Console.WriteLine(msg);
        }
        public void AttachingChildTask()
        {
            var parentTask = Task.Factory.StartNew(() => {
            Print("I am parent");
            var childTask = Task.Factory.StartNew(() => {
                Print("Child Task staring");
                Thread.Sleep(3000);
                Print("Child Task Ending");
            }, TaskCreationOptions.AttachedToParent);

                var completeHandler = childTask.ContinueWith(t =>
                {
                    Print("Success");
                }, TaskContinuationOptions.AttachedToParent | TaskContinuationOptions.OnlyOnRanToCompletion);

                var faultHandler = childTask.ContinueWith(t =>
                {
                    Print("Success");
                }, TaskContinuationOptions.AttachedToParent | TaskContinuationOptions.OnlyOnFaulted);

                childTask.Start();
        });
            parentTask.Start();

            try
            {
                parentTask.Wait();
            }
            catch (AggregateException ae)
            {
                ae.Handle(e => true);
            }
        }
    }
}
