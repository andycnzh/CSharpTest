using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTest
{
    class FinalizeTest
    {
        public class Parent
        {
            public Parent()
            {
                Console.WriteLine("Create Parent");
            }

            ~Parent()
            {
                Console.WriteLine("Clear Parent");
            }
        }

        public class Child : Parent
        {
            public Child()
            {
                Console.WriteLine("Create Child");
            }

            ~Child()
            {
                Console.WriteLine("Clear Child");
            }
        }

        public class GrandChild : Child
        {
            public GrandChild()
            {
                Console.WriteLine("Create GrandChild");
            }

            ~GrandChild()
            {
                Console.WriteLine("Clear GrandChild");
            }
        }

        public void DoWork()
        {
            GrandChild temp = new GrandChild();
            temp = null; //遗弃对象，等待垃圾回收
            GC.Collect();

            FileManager fs = null;
            using (fs = new FileManager())
            {
                Console.WriteLine(fs.ToString());
            }

        }

        public class FileManager : IDisposable
        {
            private bool disposed = false;
            //非托管资源
            private IntPtr handle;
            //托管资源
            FileStream fs = null;

            public FileManager()
            {
            }

            ~FileManager()
            {
                //GC调用，终结
                Dispose(false);
            }

            public void Dispose()
            {
                //显示关闭
                Dispose(true);
                //通知GC不必再调用Finalize()
                GC.SuppressFinalize(this);
            }

            protected virtual void Dispose(bool disposing)
            {
                if (!this.disposed)
                {
                    if (disposing && fs != null)
                    {
                        // 释放托管资源
                        fs.Dispose();
                    }

                    //释放非托管资源
                    //...
                    handle = IntPtr.Zero;

                    disposed = true;
                }

            }
        }
    }
}
