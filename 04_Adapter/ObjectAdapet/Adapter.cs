namespace _04_Adapter.ObjectAdapet
{
    public class Adapter : Target
    {
        private readonly Adaptee _adaptee;
        public Adapter()
        {
            _adaptee = new Adaptee();
        }

        public override void Operation()
        {
            _adaptee.Operation();
        }
    }
}
