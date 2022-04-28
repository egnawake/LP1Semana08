using System;

namespace GameUnits
{
    // Unit deve ser abstrata porque nao tem funcionalidade suficiente para
    // ser util no jogo por si so.
    // Serve apenas para definir comportamento que todas as unidades tem.
    public abstract class Unit
    {
        private int movement;

        // Health deve ser virtual porque unidades diferentes podem ter
        // formulas especificas para calcular os seus pontos de vida.
        public virtual int Health { get; set; }
        public abstract float Value { get; }

        public Unit(int movement, int health)
        {
            this.movement = movement;
            Health = health;
        }

        public void Move()
        {
            Console.WriteLine($"Unit has moved {movement} spaces");
        }

        public override string ToString()
        {
            return $"Unit (Health: {Health}, Value: {Value})";
        }
    }
}
