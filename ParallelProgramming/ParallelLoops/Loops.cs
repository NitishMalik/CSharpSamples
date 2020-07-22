using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ParallelProgramming
{
    public class Loops
    {        
        public void ParalleLoopMethod()
        {
            var a = new Action(() => Console.WriteLine($"First task {Task.CurrentId}"));
            var b = new Action(() => Console.WriteLine($"Second task {Task.CurrentId}"));
            var c = new Action(() => Console.WriteLine($"Third task {Task.CurrentId}"));

            Parallel.Invoke(a, b, c);

            Parallel.For(1, 11, i =>
            {
                Console.WriteLine($"{i * i}");
            });

            string[] arr = { "oh", "what", "a", "day" };
            Parallel.ForEach(arr, word =>
            {
                Console.WriteLine($"{word} has length {word.Length} , {Task.CurrentId}");
            });
        }

        private static ParallelLoopResult result;
        public void CancellableParallelLoopMethod()
        {
            var cts = new CancellationTokenSource();
            
            ParallelOptions po = new ParallelOptions();
            po.CancellationToken = cts.Token;

            result = Parallel.For(0, 20, po, (int x, ParallelLoopState state) =>
            {
                Console.WriteLine($"Tasks {Task.CurrentId}");
                if (x == 10)
                {
                    // Handle OperationCancelled in parent try catch
                    // cts.Cancel();
                    // Not so Immediate Stop
                    // state.Stop();
                    // Immediate Stop
                    // state.Break();
                    // handle Aggregate in the parent try catch
                    throw new Exception();
                }
            });

            Console.WriteLine();
            Console.WriteLine($"was loop completed? { result.IsCompleted}");
        }

        [Benchmark]
        public void SquareEachValueWithChunk ()
        {
            const int count = 1000;
            var values = Enumerable.Range(0, count);
            var results = new int[count];

            var part = Partitioner.Create(0, count, 100);
            Parallel.ForEach(part, range =>
           {
               for (int i = range.Item1; i < range.Item2; i++)
               {
                   results[i] = (int)Math.Pow(i, 2);
               }
           });
        }
    }
}
