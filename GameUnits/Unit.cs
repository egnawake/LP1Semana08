using System;

namespace GameUnits
{
    public class Unit
    {
        private int movement;
        public int Health { get; set; }

        public Unit(int movement, int health)
        {
            this.movement = movement;
            Health = health;
        }

        public void Move(int spaces)
        {
            Console.WriteLine($"Unit has moved {spaces} spaces");
        }
    }
}
