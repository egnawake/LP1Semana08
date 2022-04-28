namespace GameUnits
{
    public class MilitaryUnit : Unit
    {
        public int AttackPower { get; }
        public int XP { get; set; }

        public MilitaryUnit(int movement, int health, int power) : base(movement, health)
        {
            AttackPower = power;
            XP = 0;
        }
    }
}
