using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTest
{
    public delegate void ShowMessage(string msg);

    class DelegateTest
    {
        public void ShowString(string str)
        {
            Console.WriteLine("ShowString " + str);
        }

        public void TestCall()
        {
            ShowMessage callShow = new ShowMessage(ShowString);
            callShow("Direct call");
        }

        public void TestInvoke()
        {
            ShowMessage invokeShow = new ShowMessage(ShowString);
            invokeShow.Invoke("Invoke call");
        }

        public delegate Parent MyDel(Child para);

        private Child MyMethod(Parent para)
        {
            return new Child();
        }

        public void TestDelegate()
        {
            MyDel del = new MyDel(MyMethod);
            del(new Child());
        }

        public class Parent
        {
            public string Name { get; set; }
        }

        public class Child : Parent
        {
            public int Age { get; set; }
        }

        public void TestAction()
        {
            Action<string> act = new Action<string>(ShowString);
            act("This is Action");
        }

        public void TestFunction()
        {

        }
    }
}
