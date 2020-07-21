using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ParallelProgramming
{
    

    public class BarrierSample
    {
        private CountdownEvent cte = new CountdownEvent(5);
        public static void Print(string msg)
        {
            Console.WriteLine(msg);
            
        }

        //All Participants have to react a barrier and wait for other to reach there to go forward
        Barrier barrier = new Barrier(2, b => Print($"Phase {b.CurrentPhaseNumber} is finished"));

        public void Water()
        {
            // In Countdown, its like 
            cte.Signal();
            cte.Wait();

            Print("Putting kettle ON..(takes a bit longer)");
            Thread.Sleep(2000);
            barrier.SignalAndWait();
            Print("Pouring water...");
            barrier.SignalAndWait();
            Print("Putting Kettle away");
        }

        public void Cup()
        {
            Print("Finding teh nicest cup..(takes a bit longer)");
            barrier.SignalAndWait();
            Print("Adding tea...");
            barrier.SignalAndWait();
            Print("Adding Sugar..");
        }

        public void PrepareTea()
        {
            var water = Task.Factory.StartNew(Water);
            var cup = Task.Factory.StartNew(Cup);
            var tea = Task.Factory.ContinueWhenAll(new[] { water, cup }, tasks =>
            {
                Print("Enjoy your cup of tea!!");
            });
            tea.Wait();
        }
    }
}
