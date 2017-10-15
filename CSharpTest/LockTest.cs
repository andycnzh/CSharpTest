using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpTest
{
    class LockTest
    {
        #region variable 
        Thread thread1 = null;
        Thread thread2 = null;
        Mutex mutex = null;
        #endregion

        public LockTest()
        {
            mutex = new Mutex();
            thread1 = new Thread(new ThreadStart(Thread1Func));
            thread2 = new Thread(new ThreadStart(Thread2Func));
        }

        private void Thread2Func()
        {
            for (int count = 0; count < 10; count++)
            {
                //TestFunc("Thread2 have run " + count.ToString() + " times");
                TestFuncWithLock("***Thread2 have run " + count.ToString() + " times");
                Thread.Sleep(100);
            }
        }

        private void Thread1Func()
        {
            for (int count = 0; count < 10; count++)
            {
                //TestFunc("Thread1 have run " + count.ToString() + " times");
                TestFuncWithLock("###Thread1 have run " + count.ToString() + " times");
                Thread.Sleep(30);
            }
        }

        private void TestFunc(string str)
        {
            Console.WriteLine("{0} {1}", str, System.DateTime.Now.Millisecond.ToString());
            Thread.Sleep(50);
        }

        private void TestFuncWithLock(string str)
        {
            lock (this)
            {
                Console.WriteLine("{0} {1}", str, System.DateTime.Now.Millisecond.ToString());
                Thread.Sleep(50);
            }
        }

        private void TestFunWithMonitor(string str)
        {
            Monitor.Enter(this);
            Console.WriteLine("{0} {1}", str, System.DateTime.Now.Millisecond.ToString());
            Thread.Sleep(50);
            Monitor.Exit(this);
        }

        public void RunTest()
        {
            thread1.Start();
            thread2.Start();
        }
    }
}
