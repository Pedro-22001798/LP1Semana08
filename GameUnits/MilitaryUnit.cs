namespace GameUnits
{
    public class MilitaryUnit : Unit
    {
        private float _xp = 0;
        private float _attack = 1;

        public override float Health { get => base.Health + _xp; set => base.Health = value; }
        public override float Cost {get => _attack + _xp;}

        public void Attack(Unit attackedUnit)
        {
            _xp += 1;
            attackedUnit.Health -= _attack;
        }

    }
}