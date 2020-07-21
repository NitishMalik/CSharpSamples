using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational
{
    public class Singleton
    {
        //Lock object - Performance not that good as lock is acquired evrytime
        //Option 1 
        private static readonly object lockObject = new object();
        private static Singleton instance = null;
        private Singleton()
        {
            // No body from outside should be allowed to call
        }

        
        //Option 1
        public static Singleton GetInstance
        {
            get
            {
                lock (lockObject)
                {
                    if(instance == null)
                    {
                        instance = new Singleton();
                    }
                    return instance;
                }
            }
        }

        //Option 2 
        private static readonly Lazy<Singleton> lazy = new Lazy<Singleton>(() => new Singleton());
        public static Singleton Instance
        {
            get
            {
                return lazy.Value;
            }
        }
        
        public void PrintMessage()
        {
            Console.WriteLine("Using Singleton instance");
        }
    }
}
