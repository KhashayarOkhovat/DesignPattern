using _01_Decorator;

Console.WriteLine("ConcreteComponent :");

ConcreteComponent concrete = new ConcreteComponent();
concrete.Operation();

Console.WriteLine("----------------------------");

Console.WriteLine("ConcreteDecorator :");

ConcreteComponent concrete2 = new ConcreteComponent();
ConcreteDecorator ConcreteDecorator = new ConcreteDecorator(concrete2);
ConcreteDecorator.Operation();
Console.ReadKey();
