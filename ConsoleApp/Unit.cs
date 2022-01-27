namespace ConsoleApp
{
    public class Unit
    {
        private string _name;
        private int _attackDmg;
        private int _health;

        public Unit(string name, int attackDmg, int health)
        {
            _name = name;
            _attackDmg = attackDmg;
            _health = health;
        }

        public void Attack(Unit other)
        {
            other.Health -= AttackDmg; //hm
        }

        public string Name
        {
            get
            {
                return _name;
            }
        }

        public int AttackDmg
        {
            get
            {
                return _attackDmg;
            }
        }

        public int Health
        {
            get
            {
                return _health;
            }
            set
            {
                if (value < 0) _health = 0;
                else _health = value;
            }
        }
    }
}