namespace DND4E.Items.Weapons
{
    public class Broadsword : Weapon
    {
        public Broadsword()
        {
            Name = "Broadsword";
            DieSize = 10;
            Cost = 20;
            Weight = 5;
            Groups = new string[] { "Heavy Blade" };
            Properties = new string[] { "Versatile" };
        }
    }
}
