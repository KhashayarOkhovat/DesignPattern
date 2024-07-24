using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Decorator
{
    public abstract class Decorator : Component
    {
        private readonly Component _component;

        public Decorator(Component component)
        {
            _component = component;
        }
        public override void Operation()
        {
            _component.Operation();

        }
    }
    public class ConcreteDecorator : Decorator
    {
        public ConcreteDecorator(Component component):base(component)
        {

        }

        public override void Operation()
        {
            base.Operation();
            Console.WriteLine("ConcreteDecorator.Operation()");
        }
    }
}
