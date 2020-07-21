using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ParallelProgramming
{
    public class Record
    {
        public string key;
        public string value;
    }
    public class ConcurrentDic
    {
        private ConcurrentDictionary<string, string> concurrDic = new ConcurrentDictionary<string, string>();
        private ConcurrentQueue<int> queue = new ConcurrentQueue<int>();
        private ConcurrentStack<int> stack = new ConcurrentStack<int>();
        private ConcurrentBag<int> bag = new ConcurrentBag<int>();

        public void AddRecord(object record)
        {
            Record rec = ( Record)record;
            bool success = concurrDic.TryAdd(rec.key, rec.value);
            string who = Task.CurrentId.HasValue ? Task.CurrentId.ToString() : "Main thread";
            Console.WriteLine($"{(success ? "Added by" : "Failed by - ")} {who}");
        }

        public void PrintRecords()
        {
            object record = new Record() { key = "India", value = "Delhi" };
            Task.Factory.StartNew(AddRecord, record);
            AddRecord(record);
            Task.Factory.StartNew(AddRecord, record);            
        }
    }
}

