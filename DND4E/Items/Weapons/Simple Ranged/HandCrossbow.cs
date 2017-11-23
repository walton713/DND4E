namespace DND4E.Items.Weapons
{
    public class HandCrossbow : Weapon
    {
        public HandCrossbow()
        {
            Name = "Hand Crossbow";
            ShortRange = 10;
            LongRange = 20;
            Cost = 25;
            Weight = 2;
            Groups = new string[] { "Crossbow" };
            Properties = new string[] { "Load Free" };
            IsMelee = false;
        }
    }
}
