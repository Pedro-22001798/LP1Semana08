namespace GameUnits
{
    public class MilitaryUnit : Unit
    {
        public int XP { get; private set; }
        public int AttackPower { get; }  
        public override float Cost {get { return AttackPower + XP;}}

        public MilitaryUnit(int mov, int health, int attackPower) : base(mov, health)
        {
            AttackPower = attackPower;
            XP = 0;
        }
        public void Attack(Unit attackedUnit)
        {
            XP += 1;
            attackedUnit.Health -= AttackPower;
        }

        public override string ToString()
        {
            return $"{base.ToString()} AP={AttackPower} XP={XP}";
        }

    }
}