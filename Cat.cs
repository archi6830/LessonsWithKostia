using System;

namespace ConsoleApp1;

public class Cat : Animal
{
    private bool _isWild;



    public bool IsWild
    {
        get
        {
            if (_isWild == true)
            {

                IsCanGoOut = false;

                return _isWild;
            }
            else
            {
                IsCanGoOut = true;
                return _isWild;
            }
        }
    }


    public Cat(string name, string brid, float massa, bool posibilityToGoOut , bool iswild) : base(name, brid, posibilityToGoOut ,massa)
    {
        _isWild = iswild;
        IsHungry = false;
    }


    public void Attacks()
    {
        if (_isWild == true)
        {
            System.Console.WriteLine("Yes");
        }
        else
        {
            System.Console.WriteLine("No");
        }


    }

    public override void Eat()
    {
        System.Console.WriteLine(Name + " " + "Сытая");
        System.Console.WriteLine();
    }
    public override void MakeSound()
    {
        System.Console.WriteLine(Name + " " + "Мяу");
    }
    public override void CanGoOut()
    {
        if (_isWild)
        {
            IsCanGoOut = false;
            Console.WriteLine(Name + " Не может выходить");
        }
        else
        {
            IsCanGoOut = true;
            Console.WriteLine(Name + " Можно выпустить");
        }
    }
}
