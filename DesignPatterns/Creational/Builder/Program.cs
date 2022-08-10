using BuilderPattern;

Console.Title = "BuilderPattern";

Director director = new Director();

Builder b1 = new ConcreteBuilder1();
Builder b2 = new ConcreteBuilder2();

// Construct two products
director.Construct(b1);
Product p1 = b1.GetResult();
p1.Show();

director.Construct(b2);
Product p2 = b2.GetResult();
p2.Show();


Console.WriteLine("");

var garage = new Garage();

var miniBuilder = new MiniBuilder();
var bmwBuilder = new BMWBuilder();

garage.Construct(miniBuilder);
garage.Show();

garage.Construct(bmwBuilder);
garage.Show();
 
Console.ReadKey();