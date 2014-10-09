namespace TheSlum
{
    using System.Collections.Generic;
    using System.Linq;
    using TheSlum.Interfaces;

    public class Healer : Character, IHeal
    {
        public Healer(string id, int x, int y, Team team) : base(id, x, y, 75, 50, team, 6)
        {
            this.HealingPoints = 60;
            this.IsAlive = true;
        }

        public int HealingPoints { get; set; }

        public override Character GetTarget(IEnumerable<Character> targetsList)
        {
            return targetsList.OrderBy(character => character.HealthPoints).FirstOrDefault(character => !character.Equals(this) || !character.Team.Equals(this.Team));
        }

        public override void AddToInventory(Item item)
        {
            this.Inventory.Add(item);
            ApplyItemEffects(item);
        }

        public override void RemoveFromInventory(Item item)
        {
            this.Inventory.Remove(item);
            RemoveItemEffects(item);
        }

        public override string ToString()
        {
            return base.ToString() + ", Healing: " + this.HealingPoints;
        }
    }
}
