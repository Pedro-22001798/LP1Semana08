namespace GameUnits
{
    public abstract class Unit
    {
        int movement = 0;
        public abstract float Cost {get;}
        public virtual float Health {get; set;}

        public int Move()
        {
            return movement;
        }
    }
}