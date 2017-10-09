using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTest
{
    class Program
    {
        static void Main(string[] args)
        {
            TypeConvert convert = new TypeConvert();
            //convert.TypeConvertTest();
            //convert.OverflowTest();
            convert.BoxAndUnBox();

            Console.ReadLine();
        }
    }
}
