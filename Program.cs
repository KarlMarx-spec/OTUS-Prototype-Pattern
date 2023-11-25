using OTUS_Prototype_Pattern.Clases;

var transport = new Transport("Машина");
var wheelTransport = new WheelTransport("Машина", 4);
var car = new Car("Машина", 4, "BMW", "X5", 249,  250);

var transportMyClone = transport.Clone();
var wheelTransportMyClone = wheelTransport.Clone();
var carMyClone = car.Clone();

var transportClone = (transport as ICloneable).Clone();
var wheelTransportClone = (wheelTransport as ICloneable).Clone();
var carClone = (car as ICloneable).Clone();

Console.WriteLine("----------------------------------------");
Console.WriteLine("Transport");
Console.WriteLine($"Original: {transport.Output()}");
Console.WriteLine($"Clone: {(transportClone as Transport).Output()}");
Console.WriteLine($"MyClone: {transportMyClone.Output()}");
Console.WriteLine("----------------------------------------");
Console.WriteLine("WheelTransport");
Console.WriteLine($"Original: {wheelTransport.Output()}");
Console.WriteLine($"Clone: {(wheelTransportClone as WheelTransport).Output()}");
Console.WriteLine($"MyClone: {wheelTransportMyClone.Output()}");
Console.WriteLine("----------------------------------------");
Console.WriteLine("Car");
Console.WriteLine($"Original: {car.Output()}");
Console.WriteLine($"Clone: {(carClone as Car).Output()}");
Console.WriteLine($"MyClone: {carMyClone.Output()}");
Console.WriteLine("----------------------------------------");
