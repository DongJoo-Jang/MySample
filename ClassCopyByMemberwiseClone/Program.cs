// See https://aka.ms/new-console-template for more information

Node node = new Node();
node.Name = "DongJoo";
node.Data = 123123;
node.car = new Car("인터스텔라그레이", "1600");

Node copy = node.Clone();
Console.WriteLine(copy.Name);
Console.WriteLine(copy.Data);
Console.WriteLine(copy.car.Color);

copy.Data = 22222;
copy.Name = "장동주";
copy.car.Color = "블랙";

Console.WriteLine($"복사본 수정{copy.Name}");
Console.WriteLine($"복사본 수정{copy.Data}");
Console.WriteLine($"복사본 수정{copy.car.Color}");

Console.WriteLine($"원본{node.Name}");
Console.WriteLine($"원본{node.Data}");
Console.WriteLine($"원본{node.car.Color}");





public class Node
{
    public int Data { get; set; }
    public string Name { get; set; }

    public Car car { get; set; }

    public Node Clone()
    {
        
        return this.MemberwiseClone() as Node;
    }
}

public class Car
{
    public string Color { get; set; }
    public string Power { get; set; }

    public Car(string color, string power)
    {
        Color = color;
        Power = power;
        
    }
}