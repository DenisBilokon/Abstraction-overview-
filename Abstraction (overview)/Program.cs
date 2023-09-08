using System;
public abstract class Fruit
{
    public string Name { get; set; } 
    public string Color { get; set; }     //Желательно выносить отдельно
    public Fruit(string name, string color) 
    {
        Name = name;
        Color = color;
    }
    public abstract void DisplayInfo();
}

public interface IEdible
{
    void Eat();
}

public class Apple : Fruit, IEdible  //Яблоко - фрукт, наследуеться (а интерфейс реализируеться)
{
    public Apple(string color) : base("Яблоко", color)
    {
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Фрукт: {Name}, Цвет: {Color}");
    }

    public void Eat()
    {
        Console.WriteLine($"{Name} съедено.");
    }
}

public class Banana : Fruit, IEdible
{
    public Banana(string color) : base("Банан", color)
    {
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Фрукт: {Name}, Цвет: {Color}");
    }

    public void Eat()
    {
        Console.WriteLine($"{Name} съедено.");
    }
}

class Program
{
    static void Main() 
    {
        Fruit apple = new Apple("красное");
        Fruit banana = new Banana("желтое");

        apple.DisplayInfo();
        banana.DisplayInfo();

        ((IEdible)apple).Eat(); //вызов метода поедания
        ((IEdible)banana).Eat();
    }
}
