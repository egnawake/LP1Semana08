using System;

namespace GameUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Warrior");
            MilitaryUnit warrior = new MilitaryUnit(3, 25, 5);
            warrior.Move();
            Console.WriteLine($"Health: {warrior.Health}");
            Console.WriteLine($"Value: {warrior.Value}");
            Console.WriteLine("");

            Console.WriteLine("Warrior as string:");
            Console.WriteLine(warrior);
            Console.WriteLine("");

            Console.WriteLine("Settler");
            SettlerUnit settler = new SettlerUnit(2, 15);
            settler.Move();
            Console.WriteLine($"Health: {settler.Health}");
            Console.WriteLine($"Value: {settler.Value}");
            Console.WriteLine("");
        }
    }
}
