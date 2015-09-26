using RPGGame.Interfaces;

namespace RPGGame.Characters
{
    class Priest : Character, IHeal
    {
        private const int PriestDamage = 100;
        private const int PriestHealth = 125;
        private const int PriestMana = 200;
        private const int HealingPoints = 50;
        private const int HealingManaCost = 20;
        public Priest()
            : base(PriestHealth, PriestMana, PriestDamage)
        {
        }

        public override void Attack(Character target)
        {
            target.Health -= this.Damage;
            this.Health += this.Damage / 10;
        }

        public void Heal(Character target)
        {
            target.Health += HealingPoints;
            this.Mana -= HealingManaCost;
        }
    }
}
