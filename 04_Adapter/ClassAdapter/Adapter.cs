namespace _04_Adapter.ClassAdapter
{
    public class Adapter : Adaptee, ITarget
    {
        public void Operation()
        {
            throw new NotImplementedException();
        }
    }
}
