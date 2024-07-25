using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_03_Bridge.Implementor
{
    public abstract class Color
    {
        public abstract void Drew();
    }
    public class Blue : Color
    {
        public override void Drew()
        {
            Console.WriteLine("Is Blue");
        }
    }
    public class Red : Color
    {
        public override void Drew()
        {
            Console.WriteLine("Is Red");
        }
    }
}
