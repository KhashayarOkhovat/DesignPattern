using _01_03_Bridge.Implementor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_03_Bridge.Abstraction
{
    public abstract class Shape
    {
        protected Color _color;
        public Shape(Color color)
        {
            _color = color;
        }
        public void ShapeColoring()
        {
            _color.Drew();
        }
    }
    public class Circle : Shape
    {
        public Circle(Color color):base(color)
        {

        }
    }
    public class Square : Shape
    {
        public Square(Color color) : base(color)
        {

        }
    }
}
