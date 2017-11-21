namespace DND4E.Items.Weapons
{
    public class Scimitar : Weapon
    {
        public Scimitar()
        {
            Name = "Scimitar";
            DieSize = 8;
            Cost = 10;
            Weight = 4;
            Groups = new string[] { "Heavy Blade" };
            Properties = new string[] { "High Crit" };
        }
    }
}
