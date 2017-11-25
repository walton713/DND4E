namespace DND4E.Items.Weapons
{
    public class Scourge : Weapon
    {
        public Scourge()
        {
            Name = "Scourge";
            DieSize = 8;
            Cost = 3;
            Weight = 2;
            Groups = new string[] { "Flail" };
            Properties = new string[] { "Off-Hand" };
        }
    }
}
