namespace GameUnits
{
    public class SettlerUnit : Unit
    {
        private float _cost = 5;
        private float _movement;
        private float _health;

        public override float Cost {get => _cost;}
        public override float Health {get => _health;}

        public SettlerUnit()
        {
            _movement = 1;
            _health = 2;
        }
    }
}