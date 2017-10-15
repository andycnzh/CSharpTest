using MyAssemblyA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTest
{
    class TestCar
    {
        public void Test(string carType)
        {
            string assemblyName = "MyAssemblyB, Version=1.0.0.0, Culture=neutral, PublicToken=null";

            Assembly assembly = Assembly.Load(assemblyName);

            Type t = assembly.GetType(carType);

            var obj = Activator.CreateInstance(t);

            ICar car = obj as ICar;

            if (car != null)
            {
                car.Run();
                car.Turn(Direction.East);
            }
        }
    }
}
