using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTest
{
    class AbstractClassTest
    {
        abstract class AbstractClassBase
        {
            public AbstractClassBase()
            {
                Console.WriteLine("Abstract class construct method");
            }

            public void TestMethod1()
            {
                Console.WriteLine("This is test method 1 in base class.");
            }

            public abstract void TestMethod2();

            public virtual void TestMethod3()
            {
                Console.WriteLine("This is virtual method 3 in base class.");
            }
        }

        abstract class AbstractClassChild : AbstractClassBase
        {
            public override void TestMethod2()
            {
                Console.WriteLine("This is abstract method 2 in child class.");
            }

            //public override abstract void TestMethod3();

            public abstract override void TestMethod3();
        }

        class AbstractClassChild2 : AbstractClassBase
        {
            public override void TestMethod2()
            {
                Console.WriteLine("This is abstract method 2 in child class.");
            }

            public override void TestMethod3()
            {
                Console.WriteLine("This is override abstract method 3 in child class.");
            }
        }
    }
}
