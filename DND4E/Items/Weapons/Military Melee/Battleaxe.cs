namespace DND4E.Items.Weapons
{
    public class Battleaxe : Weapon
    {
        public Battleaxe()
        {
            Name = "Battleaxe";
            DieSize = 10;
            Cost = 15;
            Weight = 6;
            Groups = new string[] { "Axe" };
            Properties = new string[] { "Versatile" };
        }
    }
}
