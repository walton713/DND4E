namespace DND4E.Items.Weapons
{
    public class Shortbow : Weapon
    {
        public Shortbow()
        {
            Name = "Shortbow";
            DieSize = 8;
            ShortRange = 15;
            LongRange = 30;
            Cost = 25;
            Weight = 2;
            Groups = new string[] { "Bow" };
            Properties = new string[] { "Load Free", "Small" };
            IsTwoHanded = true;
            IsMelee = false;
        }
    }
}
