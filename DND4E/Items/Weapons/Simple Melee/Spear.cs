namespace DND4E.Items.Weapons
{
    public class Spear : Weapon
    {
        public Spear()
        {
            Name = "Spear";
            DieSize = 8;
            Cost = 5;
            Weight = 6;
            Groups = new string[] { "Spear" };
            Properties = new string[] { "Versatile" };
        }
    }
}
