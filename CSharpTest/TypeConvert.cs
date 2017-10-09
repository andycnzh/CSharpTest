using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTest
{
    class TypeConvert
    {
        public class Person
        {
            public string Name { get; set; }
        }

        public class Teacher : Person
        {
            public string Grade { get; set; }
        }

        public void TypeConvertTest()
        {
            Teacher teacher = new Teacher();
            // type convert is OK
            Person person = teacher;

            person.Name = "abc";
            // type convert is OK
            teacher = (Teacher)person;

            // type convert is OK, and return value is not null
            Person person1 = teacher as Person;
            if (person1 != null)
            {
                // Do something here
            }

            Person person2 = new Person();
            if (person2 is Teacher)
            {
                // Do type convert here
            }
            // type convert failed, and return value is null
            teacher = person2 as Teacher;

            Person person3 = new Person();
            // Exception here: Unable to cast object of type 'Person' to type 'Teacher'.
            teacher = (Teacher)person3;
        }

        public void OverflowTest()
        {
            int m = int.MaxValue;
            int a = 2147483647;
            // -2147483648
            int b = a + 1;

            int c;
            try
            {
                c = checked(a + 1);
            }
            catch (Exception)
            {
                // handle exception here
            }

            int d = unchecked(a + 1);

            checked { int e = a + 1; }
            unchecked { int f = a + 1; }
        }

        public void BoxAndUnBox()
        {
            // Box
            int a = 1;
            object obj = a;

            // Unbox
            object obj2 = 2;
            int b = (int)obj2;
        }
    }
}
