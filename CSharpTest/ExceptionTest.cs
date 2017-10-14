using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTest
{
    class ExceptionTest
    {
        public void Method0()
        {
            try
            {
                Method1();
            }
            catch
            {
                Console.WriteLine("Method0 catch");
            }
            finally
            {
                Console.WriteLine("Method0 finally");
            }
        }

        public void Method1()
        {
            try
            {
                Method2();
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Method1 catch NullReferenceException");
            }
            catch (FileNotFoundException fileNot)
            {
                Console.WriteLine("Method1 catch FileNotFoundException");
                throw fileNot;
            }
            finally
            {
                Console.WriteLine("Method1 finally");
            }
        }
        public void Method2()
        {
            FileStream fs = null;

            try
            {
                //假如c:\\file.txt不存在，这里一定会抛出文件未找到异常
                fs = new FileStream("c:\\file.txt", FileMode.Open);
                fs.ReadByte();
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Method2 ArgumentException");
            }
            finally
            {
                Console.WriteLine("Method2 finally");
                if (fs != null)
                    fs.Close();
                fs = null;
            }
        }
    }
}
