using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ParallelProgramming
{
    public class TaskInfo
    {
        public void CreatSimpleTasks()
        {
            string param1 = "nitish", param2 = "malik";
            // 1. Task with param and return type 
            Task<int> task1 = new Task<int>(GetLength, param1);
            Task<int> task2 = Task.Factory.StartNew(GetLength, param2);

            Console.WriteLine($"Length of {param1} is {task1.Result}");
            Console.WriteLine($"Length of {param2} is {task2.Result}");

        }

        public void CreateCancellableTask()
        {
            CancellationTokenSource cts = new CancellationTokenSource();
            CancellationToken token = cts.Token;

            token.Register(() =>
            {
                Console.WriteLine("Please inform me when cancellation requestd");
            });

            Task task1 = new Task(() =>
            {
                int i = 0;
                while (true)
                {
                    token.ThrowIfCancellationRequested();
                    Console.WriteLine(i++);
                }
            }, token);
            task1.Start();

            // Another way to wait for the task cancellation
            Task.Factory.StartNew(() =>
            {
                // token.WaitHandle.WaitOne();
                // Another way to wait for particular time
                bool isDone = token.WaitHandle.WaitOne(5000);
                if (isDone)
                {
                    Console.WriteLine("Handle cancelled within 5 secs");
                }

                Console.WriteLine("I was waiting for other task to be cancelled");
            }, token);

            Console.WriteLine("Back to main thread and executing my task");
            Console.ReadLine();
            cts.Cancel();
        }

        public void ExceptionHandling()
        {
            try
            {
                ExceptionHandlingChild();
            }
            catch(AggregateException ae)
            {
                foreach(var ex in ae.InnerExceptions)
                {
                    Console.WriteLine($"Handle in Parent: {ex.GetType()}");
                }
            }
        }

        private void ExceptionHandlingChild()
        {
            Task t1 = new Task(() =>
            {
                throw new InvalidOperationException("Cant do this!") { Source = "t1" };
            });
            t1.Start();

            Task t2 = new Task(() =>
            {
                throw new AccessViolationException("Not allowed") { Source = "t2" };
            });
            t2.Start();

            try
            {
                Task.WaitAll(t1, t2);
            }
            catch(AggregateException ae)
            {
                ae.Handle(e =>
                {
                    if (e is InvalidOperationException)
                    {
                        Console.WriteLine("Handled Invalid Operation Exception");
                        return true;
                    }

                    return false;
                }) ;                
            }
        }

        public int GetLength(object param)
        {
            Console.WriteLine($"\n Task with id {Task.CurrentId} processing param {param}");
            return param.ToString().Length;
        }
    }
}
