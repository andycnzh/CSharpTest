using MyAssemblyA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAssemblyB
{
    public class BenzCar : ICar
    {
        public BenzCar()
        { }

        public string Owner { get; set; }

        public void Run()
        {
            Console.WriteLine("BenzCar Run");
        }

        public void Turn(Direction direction)
        {
            Console.WriteLine("BenzCar Turn: " + direction.ToString());
        }

    }
}
