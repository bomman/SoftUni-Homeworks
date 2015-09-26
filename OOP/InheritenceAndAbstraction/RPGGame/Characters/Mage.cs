namespace RPGGame.Characters
{
    class Mage : Character
    {
        private const int MageDamage = 120;
        private const int MageHealth = 120;
        private const int MageMana = 120;

        public Mage()
            : base(MageHealth, MageMana, MageDamage)
        {

        }

        public override void Attack(Character target)
        {
            target.Health -= this.Damage * 2;
            this.Mana -= 100;
        }
    }
}
