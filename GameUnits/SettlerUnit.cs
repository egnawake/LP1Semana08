namespace GameUnits
{
    public class SettlerUnit : Unit
    {
        public SettlerUnit(int movement, int health) : base(movement, health)
        {

        }
        
        public void Settle(int space)
        {
            Console.WriteLine($"City founded on space {space}");
        }
    }
}
