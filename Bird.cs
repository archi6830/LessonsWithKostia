using System;

namespace ConsoleApp1;

public class Bird : Animal
{
    private bool _isFlying;
    public bool Speed { get { return _isFlying; } }


    public Bird(string name, string brid, float massa, bool posibilityToGoOut , bool isflying) : base(name, brid, posibilityToGoOut, massa)
    {
        _isFlying = isflying;
    }
    public void Fly()
    {
        if (_isFlying == true)
        {
            System.Console.WriteLine("Yes, Flying");

        }
        else
        {
            System.Console.WriteLine("No, bag of digs");
        }
    }

    public override void Eat()
    {
        System.Console.WriteLine(Name + " " + "Голодная");
    }
    public override void MakeSound()
    {
        System.Console.WriteLine(Name + " " + "Кар");
    }
    public override void CanGoOut()
    {
        System.Console.WriteLine(Name + " " + "Можно выпустить");
    }
}
