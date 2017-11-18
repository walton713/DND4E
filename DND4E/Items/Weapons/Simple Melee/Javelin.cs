namespace DND4E.Items.Weapons
{
    public class Javelin : Weapon
    {
        public Javelin()
        {
            Name = "Javelin";
            ShortRange = 10;
            LongRange = 20;
            Cost = 5;
            Weight = 2;
            Groups = new string[] { "Spear" };
            Properties = new string[] { "Heavy Thrown" };
        }
    }
}
