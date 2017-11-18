namespace DND4E.Items.Weapons
{
    public class Mace : Weapon
    {
        public Mace()
        {
            Name = "Mace";
            DieSize = 8;
            Cost = 5;
            Weight = 6;
            Groups = new string[] { "Mace" };
            Properties = new string[] { "Versatile" };
        }
    }
}
