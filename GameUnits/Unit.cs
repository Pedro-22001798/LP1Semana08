namespace GameUnits
{
    public abstract class Unit
    {
        protected int movement;
        public float Health {get; set;}
        public abstract float Cost {get;}

        public Unit(int movement, int health)
        {
            this.movement = movement;
            Health = health;
        }
        public int Move()
        {
            return movement;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name} : HP = {Health} COST = {Cost:2}";
        }
    }
}