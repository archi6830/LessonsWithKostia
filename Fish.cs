using System;
using System.Reflection.Metadata;

namespace ConsoleApp1;

public class Fish : Animal
{


    public Fish(string name, string brid, float massa, bool posibilityToGoOut) : base(name, brid, posibilityToGoOut ,massa)
    {

    }
    public new void Breathe()
    {
        System.Console.WriteLine("Дишу по другому");
    }

        public override void Eat()
    {
        System.Console.WriteLine(Name + " " + "Голодный");
    }
    public override void MakeSound()
    {
        System.Console.WriteLine(Name + " " + "Буль - буль");
    }
    public override void CanGoOut()
    {
        System.Console.WriteLine(Name + " " + "Может плавать только в аквариуме");
    }
}
