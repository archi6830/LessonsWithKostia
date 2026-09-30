using System;

namespace ConsoleApp1;

public class Animal
{
    private string _name;
    private string _brid;
    private float _massa;

    private bool _posibilityToGoOut;

    public string Name { get { return _name; } }
    public string Brid { get { return _brid; } }
    public float Massa { get { return _massa; } }

    public bool PosibilityToGoOut { get {return _posibilityToGoOut; }}

    public Animal(string name, string brid, bool posibilityToGoOut , float massa)
    {
        _name = name;
        _brid = brid;
        _massa = massa;
        _posibilityToGoOut = posibilityToGoOut;
    }

    private bool _isHungry = true;

    public bool IsHungry { get { return _isHungry; } set { _isHungry = value; } }
    private bool _isCanGoOut = true;

    public bool IsCanGoOut { get { return _isCanGoOut; } set { _isCanGoOut = value; } }

    public virtual void Eat()
    {
        //_isHungry = IsHungry;
        System.Console.WriteLine("Я кушаю");
    }
    // public void
    public static void SearchForAnimal(Animal[] animals)
    {
        for (int i = 0; i < animals.Length; i++)
        {
            int firstNumInLine = i + 1;
            string makeMenu = $"{firstNumInLine} - {animals[i].Name} ";
            System.Console.WriteLine(makeMenu);

        }
    }
    public virtual void MakeSound()
    {
        System.Console.WriteLine("-звук-");
    }
    public virtual void CanGoOut()
    {
        //_isCanGoOut = IsCanGoOut;
        if (IsCanGoOut)
        {
            System.Console.WriteLine($"{Name} Mожет выходить");
        }
        else
        {
            System.Console.WriteLine($"{Name} Mожет выходить");
        }
    }

    public void FeetAnimal()
    {
        IsHungry = false;
        System.Console.WriteLine($"{Name} Стал Сыт");

    }

    public void CheckForFullness()
    {
        if (IsHungry == false)
        {
            System.Console.WriteLine($"{Name} Был сыт");
        }
        else
        {
            FeetAnimal();
        }
    }
    public void Breathe()
    {
        System.Console.WriteLine("Дишу");
    }
    public void Walking()
    {
        System.Console.WriteLine("Гуляет");
    }

}
