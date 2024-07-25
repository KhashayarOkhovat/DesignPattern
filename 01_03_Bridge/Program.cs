using _01_03_Bridge.Abstraction;
using _01_03_Bridge.Implementor;

Console.WriteLine("Start Red Circle");
Shape shapeDrew;
shapeDrew = new Circle(new Red());
shapeDrew.ShapeColoring();
Console.WriteLine("------------------------------");
Console.WriteLine("Start Blue Square");
shapeDrew = new Square(new Blue());
shapeDrew.ShapeColoring();
Console.ReadKey();