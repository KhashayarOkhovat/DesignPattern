using _01_03_Bridge.Implementor;

namespace _01_03_Bridge.Abstraction
{
    public abstract class Shape
    {
        protected Color _color;
        public Shape(Color color)
        {
            _color = color;
        }
        public abstract void ShapeColoring();
    }
    public class Circle : Shape
    {
        public Circle(Color color):base(color)
        {

        }

        public override void ShapeColoring()
        {
            Console.WriteLine($"Circle {_color.Drew()}");
        }
    }
    public class Square : Shape
    {
        public Square(Color color) : base(color)
        {

        }

        public override void ShapeColoring()
        {
            Console.WriteLine($"Square {_color.Drew()}");
        }
    }
}
