namespace DND4E.Items.Weapons
{
    public class Kukri : Weapon
    {
        public Kukri()
        {
            Name = "Kukri";
            Cost = 10;
            Weight = 2;
            Groups = new string[] { "Light Blade" };
            Properties = new string[] { "Brutal 1", "Off-Hand" };
        }
    }
}
