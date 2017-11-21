namespace DND4E.Items.Weapons
{
    public class WarPick : Weapon
    {
        public WarPick()
        {
            Name = "War Pick";
            DieSize = 8;
            Cost = 15;
            Weight = 6;
            Groups = new string[] { "Pick" };
            Properties = new string[] { "High Crit", "Versatile" };
        }
    }
}
