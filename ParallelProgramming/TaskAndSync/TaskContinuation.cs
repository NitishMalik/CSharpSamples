using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ParallelProgramming
{
    public class TaskContinuation
    {
        public void MakeTeaTask()
        {
            var task = Task.Factory.StartNew(() => Console.WriteLine("Boling water"));
            var task2 = task.ContinueWith(task => Console.WriteLine("Add other resources"));
            task2.Wait();
        }

        public void ContinueWithAll()
        {
            var task = Task.Factory.StartNew(() => "Task1");
            var task1 = Task.Factory.StartNew(() => "Task1");

            var task3 = Task.Factory.ContinueWhenAll(new[] {task, task1 },tasks =>
            {
                foreach (var t in tasks)
                {
                    Console.WriteLine(t.Result);
                }
            });
            task3.Wait();
        }
    }
}
