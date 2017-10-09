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

            Person person2 = new Person();
            // Exception here: Unable to cast object of type 'Person' to type 'Teacher'.
            teacher = (Teacher)person2;
        }
    }
}
