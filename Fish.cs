using System;

namespace ConsoleApp1;

public class Fish : Animal
{


    public Fish(string name, string brid, float massa) : base(name, brid, massa)
    {

    }
    public new void Breathe()
    {
        System.Console.WriteLine("Дишу по другому");
    }

}
