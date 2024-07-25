namespace _01_03_Bridge.Implementor
{
    public abstract class Color
    {
        public abstract string Drew();
    }
    public class Blue : Color
    {
        public override string Drew()
        {
            var result = "Is Blue";
            return result;
        }
    }
    public class Red : Color
    {
        public override string Drew()
        {
            var result = "Is Red";
            return result;
        }
    }
}
