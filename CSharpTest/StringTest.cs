using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTest
{
    class StringTest
    {
        public void StringMemoryResident()
        {
            string str1 = "abc";
            string str2 = "abc";

            Console.WriteLine(object.Equals(str1, str2));
            Console.WriteLine(object.ReferenceEquals(str1, str2));

            str1 += str2;
            str1 = string.Intern(str1);

            string str3 = string.IsInterned(str2);

            Console.WriteLine(str1);
        }

        public void CharSet()
        {
            for (int i = 0; i < 1000; i++)
            {
                char temp = (char)i;
                Console.WriteLine(temp + " " + i);
            }
        }
    }
}
