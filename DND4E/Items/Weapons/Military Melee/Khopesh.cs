namespace DND4E.Items.Weapons
{
    public class Khopesh : Weapon
    {
        public Khopesh()
        {
            Name = "Khopesh";
            DieSize = 8;
            Cost = 20;
            Weight = 8;
            Groups = new string[] { "Axe", "Heavy Blade" };
            Properties = new string[] { "Brutal 1", "Versatile" };
        }
    }
}
