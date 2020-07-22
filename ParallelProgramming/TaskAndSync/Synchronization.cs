using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ParallelProgramming
{
    public class Synchronization
    {        
        private readonly object lockObj = new object();
        private int Balance;
        // public int Balance { get => balance; set => balance = value; }

        private void Deposit(int amount)
        {
            Balance += amount;
        }

        private void Withdraw(int amount)
        {
            Balance -= amount;
        }
        private void DepositWithLock(int amount)
        {
            lock (lockObj)
            {
                Balance += amount;
            }

            // Using interlocked 
            // Interlocked.Add(ref balance, amount);
            // Interlocked.Add(ref balance, -amount);

        }

        private void WithdrawWitLock(int amount)
        {
            lock (lockObj)
            {
                Balance -= amount;
            }
            
        }

        public void SynchronizeCheck()
        {
            List<Task> taskList = new List<Task>();
            for (int i = 0; i < 10; i++)
            {
                taskList.Add(Task.Factory.StartNew(() =>
                {
                    for (int i = 0; i < 1000; i++)
                    {
                        Deposit(100);
                    }
                }));

                taskList.Add(Task.Factory.StartNew(() =>
                {
                    for (int i = 0; i < 1000; i++)
                    {
                        Withdraw(100);
                    }
                }));
            }

            Task.WaitAll(taskList.ToArray());

            Console.WriteLine($"Final amount left in bank is {Balance}");
        }

        public void SynchronizeCheckWithMutex()
        {
            List<Task> taskList = new List<Task>();
            Mutex mutex = new Mutex();
            for (int i = 0; i < 10; i++)
            {
#pragma warning disable CA2008 // Do not create tasks without passing a TaskScheduler
                taskList.Add(Task.Factory.StartNew(() =>
                {                    
                    for (int i = 0; i < 1000; i++)
                    {
                        bool lockTaken = false;
                        try
                        {
                            lockTaken = mutex.WaitOne();
                            this.Deposit(100);
                        }
                        finally{
                            if (lockTaken) mutex.ReleaseMutex();
                        }
                    }
                }));
#pragma warning restore CA2008 // Do not create tasks without passing a TaskScheduler

#pragma warning disable CA2008 // Do not create tasks without passing a TaskScheduler
                taskList.Add(Task.Factory.StartNew(() =>
                {
                    for (int i = 0; i < 1000; i++)
                    {
                        bool lockTaken1 = false;
                        try
                        {
                            lockTaken1 = mutex.WaitOne();
                            this.Withdraw(100);
                        }
                        finally
                        {
                            if (lockTaken1) mutex.ReleaseMutex();
                        }
                    }
                }));
#pragma warning restore CA2008 // Do not create tasks without passing a TaskScheduler
            }

            Task.WaitAll(taskList.ToArray());

            Console.WriteLine($"Final amount left in bank is {this.Balance}");
        }
    }
}
