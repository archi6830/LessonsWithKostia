using System.Dynamic;
using System.Runtime.InteropServices.Marshalling;
using System.Security.Cryptography.X509Certificates;
using ConsoleApp1;

namespace Zoo;

class Program
{
    public static void Main(string[] arg)
    {

        Fish fish = new Fish("Somik", "Doberman", 3f);
        FishService(fish);
        // Animal[] allAnimals = {

        // new Dog("Tuzic", "Doberman", 3, 100),
        // new Cat("Sonia", "Veslouha", 1, true),
        // new Bird("Archi", "Royal", 0.6f, false)
        // };
        // // Animal[] animals =
        // // {
        // //     Tuzic,
        // //     Sonia,
        // //     Archi,
        // // };
        // // 1. Dayly check
        // // 1- всех голодных накормить   1.1 просигналить 2- кого можно выпустить 2.2 просигналить 3 выдать звук 
        // System.Console.WriteLine("Выбери пункт из меню");
        // System.Console.WriteLine("1. Dayly Check");
        // System.Console.WriteLine("2. Open Menu With all animals");
        // System.Console.WriteLine("3. Feet each");
        // System.Console.WriteLine("4. Make sound");
        // System.Console.WriteLine("5. Let them go");

        // int choise = int.Parse(System.Console.ReadLine());

        // switch (choise)
        // {
        //     case 1:
        //         DailyCheck(allAnimals);
        //         break;
        //     case 2:
        //         OpenSecondMenu(allAnimals);
        //         break;
        //     case 3:
        //         Animal.SearchForAnimal(allAnimals);
        //         SecondMenuForFeet(allAnimals);
        //         break;
        //     case 4:
        //         Animal.SearchForAnimal(allAnimals);
        //         SecondMenuForSound(allAnimals);
        //         break;
        //     case 5:
        //         Animal.SearchForAnimal(allAnimals);
        //         SecondMenuForWalk(allAnimals);
        //         break;
        //     case 0:
        //         break;
        // }
    }
    public static int numOfWhichAnimalFeet = int.Parse(System.Console.ReadLine());


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

    public static void SecondMenuForFeet(Animal[] animals)
    {
        animals[numOfWhichAnimalFeet - 1].CheckForFullness();
    }
    public static void SecondMenuForSound(Animal[] animals)
    {
        animals[numOfWhichAnimalFeet - 1].MakeSound();
    }
    public static void SecondMenuForWalk(Animal[] animals)
    {
        if (animals[numOfWhichAnimalFeet - 1].IsHungry)
        {
            System.Console.WriteLine("Сначала покорми");
            System.Console.WriteLine();
            System.Console.WriteLine("1 покормить");
            System.Console.WriteLine("0 выйти");
            int feetOrNo = int.Parse(System.Console.ReadLine());
            switch (feetOrNo)
            {
                case 1:
                    animals[numOfWhichAnimalFeet - 1].CanGoOut();
                    break;
                case 0:
                    break;
                default:
                    break;
            }
        }
        else
        {
            animals[numOfWhichAnimalFeet - 1].CanGoOut();
        }
    }

    public static void FishService(Fish fish)
    {
        fish.Breathe();
    }
}