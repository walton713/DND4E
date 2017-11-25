namespace DND4E.Items.Weapons
{
    public class Trident : Weapon
    {
        public Trident()
        {
            Name = "Trident";
            DieSize = 8;
            ShortRange = 3;
            LongRange = 6;
            Cost = 10;
            Weight = 4;
            Groups = new string[] { "Spear" };
            Properties = new string[] { "Versatile", "Heavy Thrown" };
        }
    }
}
