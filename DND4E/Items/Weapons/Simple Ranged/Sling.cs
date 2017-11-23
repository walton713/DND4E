namespace DND4E.Items.Weapons
{
    public class Sling : Weapon
    {
        public Sling()
        {
            Name = "Sling";
            ShortRange = 10;
            LongRange = 20;
            Cost = 1;
            Weight = 0;
            Groups = new string[] { "Sling" };
            Properties = new string[] { "Load Free" };
            IsMelee = false;
        }
    }
}
