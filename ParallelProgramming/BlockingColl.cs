using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ParallelProgramming
{
    public class BlockingColl
    {
        private BlockingCollection<int> messages = new BlockingCollection<int>(new ConcurrentBag<int>(), 10);

        private CancellationTokenSource cts = new CancellationTokenSource();

        private Random ran = new Random();

        

        public void StartProcess()
        {
            cts.Token.Register(() =>
             Console.WriteLine("Cancellation requested !!!")
            );
            try
            {
                Task.Factory.StartNew(RunProducer);
                Task.Factory.StartNew(RunConsumer);
            }catch(AggregateException ae)
            {
                Console.WriteLine("Handling exceptions");
                ae.Handle(e => true);
                Console.ReadLine();
            }
        }

        public void CancelTask()
        {
            cts.Cancel();
        }
        private void RunConsumer()
        {
            foreach (var item in messages.GetConsumingEnumerable())
            {
                cts.Token.ThrowIfCancellationRequested();
                Console.WriteLine($"Consuming {item}");
                Thread.Sleep(ran.Next(1000));
            }
        }
        private void RunProducer()
        {
            while (true)
            {
                cts.Token.ThrowIfCancellationRequested();
                int i = ran.Next(1000);
                messages.Add(i);
                Console.WriteLine($"Adding {i}");
                Thread.Sleep(ran.Next(100));
            }
        }
    }
}
