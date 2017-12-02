namespace DND4E.Items.Weapons
{
    public class Tratnyr : Weapon
    {
        public Tratnyr()
        {
            Name = "Tratnyr";
            DieSize = 8;
            ShortRange = 10;
            LongRange = 20;
            Cost = 10;
            Weight = 5;
            Groups = new string[] { "Spear" };
            Properties = new string[] { "Versatile", "Heavy Thrown" };
        }
    }
}
