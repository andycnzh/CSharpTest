using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyAssemblyA;

namespace MyAssemblyB
{
    public class AudiCar : ICar
    {
        public AudiCar()
        {

        }

        public string Owner { get; set; }

        public void Run()
        {
            Console.WriteLine("AudiCar Run");
        }

        public void Turn(Direction direction)
        {
            Console.WriteLine("AudiCar Turn: " + direction.ToString());
        }
    }
}
