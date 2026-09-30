using System;

namespace ConsoleApp1;

public class Dog : Animal
{
    private int _speed;

    public int Speed{get{return _speed;}}

    public Dog(string name, string brid, float massa, bool posibilityToGoOut , int speed): base(name,brid,posibilityToGoOut ,massa)
    {
        _speed=speed;
    }
    public int HowFast()
    {
        System.Console.WriteLine(_speed);

        return _speed;
    }
    public override void Eat()
    {
        System.Console.WriteLine(Name  + " " + "Кушает");
    }

    public override void MakeSound()
    {
        System.Console.WriteLine(Name + " " + "Гав");
    }
    public override void CanGoOut()
    {
        System.Console.WriteLine(Name + " " + "Можно выпустить");
    }
}
