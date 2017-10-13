using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTest
{
    class MyClassTest
    {
        public int age = 10;

        public MyClassTest()
        {
            age = 20;
        }

        public MyClassTest(int ageNew)
        {
            age = ageNew;
        }
    }

    class MyClassChildTest : MyClassTest
    {
        private string name = "aaa";

        public MyClassChildTest()
        {
            name = "bbb";
        }

        public int Test(int c, List<string> names)
        {
            return c + names.Count;
        }

        public void Test(string address)
        {
            address = "111";
        }

        public void Test(MyClassTest t)
        {
            t.age = 30;
        }

        public void TestOut(out string address)
        {
            address = "out 111";
        }

        public void TestOut(out MyClassTest t)
        {
            MyClassTest temp = new MyClassTest();
            temp.age += 100;

            t = temp;
        }

        public void TestRef(ref string addresss)
        {
            addresss = "ref 111";
        }

        public void TestRef(ref MyClassTest t)
        {
            t.age = 50;
        }

        public void TestOutput()
        {
            string address = "ddd";

            Test(address);

            address = "ddd";
            TestOut(out address);

            address = "ddd";
            TestRef(ref address);

            MyClassTest t = new MyClassTest();
            t.age = 100;

            Test(t);

            TestOut(out t);

            TestRef(ref t);
        }
    }
}
