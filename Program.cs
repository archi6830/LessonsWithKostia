using System.Dynamic;
using System.Runtime.InteropServices.Marshalling;
using System.Security.Cryptography.X509Certificates;
using ConsoleApp1;

namespace Zoo;

class Program
{
    public static void Main(string[] arg)
    {

        Animal[] allAnimals = {
        new Fish("Somik", "Doberman",3f, false),
        new Dog("Tuzic", "Doberman", 3, true , 100),
        new Cat("Sonia", "Veslouha", 1, true, true),
        new Bird("Archi", "Royal", 0.6f, true , false)
        };
        // Animal[] animals =
        // {
        //     Tuzic,
        //     Sonia,
        //     Archi,
        // };
        // 1. Dayly check
        // 1- всех голодных накормить   1.1 просигналить 2- кого можно выпустить 2.2 просигналить 3 выдать звук 

        while (true)
        {
            MakeMainMenu();

            int choise = int.Parse(System.Console.ReadLine());

            // Animal animalForSelect = SelectAnimal(allAnimals);

            switch (choise)
            {
                case 1:
                    DailyCheck(allAnimals);
                    //MakeMainMenu();
                    break;
                case 2:
                    OpenSecondMenu(allAnimals);
                    //MakeMainMenu();
                    break;
                case 3:
                    Animal.SearchForAnimal(allAnimals);
                    SecondMenuForFeet(SelectAnimal(allAnimals));
                    //MakeMainMenu();
                    break;
                case 4:
                    Animal.SearchForAnimal(allAnimals);
                    SecondMenuForSound(SelectAnimal(allAnimals));
                    //MakeMainMenu();
                    break;
                case 5:
                    Animal.SearchForAnimal(allAnimals);
                    SecondMenuForWalk(SelectAnimal(allAnimals));
                    //MakeMainMenu();
                    break;
                case 0:
                    break;
                default:
                    break;
            }
            if (choise == 0)
            {
                break;
            }

        }
    }
    public static void MakeMainMenu()
    {
        System.Console.WriteLine();
        System.Console.WriteLine("Выбери пункт из меню");
        System.Console.WriteLine("1. Dayly Check");
        System.Console.WriteLine("2. Open Menu With all animals");
        System.Console.WriteLine("3. Feet each");
        System.Console.WriteLine("4. Make sound");
        System.Console.WriteLine("5. Let them go");
        System.Console.WriteLine("0. Exit");


    }


    public static void DailyCheck(Animal[] animals)
    {
        for (int i = 0; i < animals.Length; i++)
        {

            string animalName = animals[i].Name;
            animals[i].CheckForFullness();
            string foolnes = animals[i].IsHungry ? "Hungry" : "Full";

            //animals[i].MakeSound();

            string makeWrite = $"{animalName} - {foolnes}";

            System.Console.WriteLine();
            System.Console.WriteLine(makeWrite);
            System.Console.WriteLine();

        }
    }
    public static void OpenSecondMenu(Animal[] animals)
    {
        System.Console.WriteLine();
        System.Console.WriteLine("1. Вывести инфу по Dog");
        System.Console.WriteLine("2. Вывести инфу по Cat");
        System.Console.WriteLine("3. Вывести инфу по Bird");

        int optionForGetInfo = int.Parse(System.Console.ReadLine());

        for (int i = 0; i < animals.Length; i++)
        {
            string foolnes = animals[i].IsHungry ? "Hungry" : "Full";

            string makeWriteForAnimal = $"{animals[i].Name} - {foolnes} ";

            switch (optionForGetInfo, animals[i])
            {
                case (2, Cat cat):
                    //System.Console.WriteLine(makeWriteForAnimal);

                    cat.Attacks();
                    break;
                case (3, Bird bird):
                    //System.Console.WriteLine(makeWriteForAnimal);

                    bird.Fly();
                    break;
                case (1, Dog dog):
                    //System.Console.WriteLine(makeWriteForAnimal);

                    dog.HowFast();
                    break;

            }
            System.Console.WriteLine(makeWriteForAnimal);
            animals[i].CanGoOut();

            // У зоопарка новое требование нельзя выпускать если  голодное доработать меню Daily check 
            // Из дейли чек убрать звуки в основном пункте меню
            // В меню новый пункт покормить 
            // Новый пункт издать звук
            // Новый пункт выпустить
            // Поправить метод Eat
            // когда выводишь на улицу если животное голодное вывести нельзя
            // 0 выход 
            // Скрытие методов и свойств
            // Различие переопределения и скрытия методов
        }

    }

    // public static void CreateNumber(int number)
    // {
    // int numOfWhichAnimalFeet = int.Parse(Console.ReadLine());

    // numOfWhichAnimalFeet = number;

    // }

    public static Animal SelectAnimal(Animal[] animals)
    {

        int numberItsAChoice = int.Parse(Console.ReadLine());

        return animals[numberItsAChoice - 1];

    }
    public static void SecondMenuForFeet(Animal animal)
    {
        animal.CheckForFullness();
    }
    public static void SecondMenuForSound(Animal animal)
    {
        animal.MakeSound();
    }
    public static void SecondMenuForWalk(Animal animal)
    {
        if (animal.PosibilityToGoOut == true)
        {
            System.Console.WriteLine("Может выйти только если сытое и не дикое");
            animal.CanGoOut();
            if (animal.IsHungry)
            {
                System.Console.WriteLine();
                System.Console.WriteLine("1 покормить");
                System.Console.WriteLine("0 выйти");
                int feetOrNo = int.Parse(System.Console.ReadLine());
                switch (feetOrNo)
                {
                    case 1:
                        animal.FeetAnimal();
                        animal.Walking();
                        break;
                    case 0:
                        break;
                    default:
                        break;
                }
            }
        }
    }

    public static void FishService(Fish fish)
    {
        fish.Breathe();
    }
}