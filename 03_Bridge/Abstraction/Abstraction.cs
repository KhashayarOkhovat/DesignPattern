using _03_Bridge.Implementor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _03_Bridge.Abstraction
{
    public abstract class Abstraction
    {
        private Implementor.Implementor _implementor;
        public virtual void Function()
        {
            _implementor = new ConcreteImplementor();

            _implementor.Implementation();
        }
    }
    public class RefinedAbstraction : Abstraction
    {

    }
}
