namespace DND4E.Items.Weapons
{
    public class Flail : Weapon
    {
        public Flail()
        {
            Name = "Flail";
            DieSize = 10;
            Cost = 10;
            Weight = 5;
            Groups = new string[] { "Flail" };
            Properties = new string[] { "Versatile" };
        }
    }
}
