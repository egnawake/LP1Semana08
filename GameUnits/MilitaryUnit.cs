using System;

namespace GameUnits
{
    public class MilitaryUnit : Unit
    {
        public int AttackPower { get; }
        public int XP { get; set; }
        public override int Health => base.Health + XP;
        public override float Value => AttackPower + XP;

        public MilitaryUnit(int movement, int health, int power) : base(movement, health)
        {
            AttackPower = power;
            XP = 0;
        }

        public void Attack(Unit u)
        {
            Console.WriteLine($"Hit unit for {AttackPower} damage");
        }

        public override string ToString()
        {
            return base.ToString()
                + $"\nMilitaryUnit (Attack power: {AttackPower}, XP: {XP})";
        }
    }
}
