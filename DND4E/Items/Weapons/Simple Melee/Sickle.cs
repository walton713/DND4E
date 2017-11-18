namespace DND4E.Items.Weapons
{
    public class Sickle : Weapon
    {
        public Sickle()
        {
            Name = "Sickle";
            Cost = 2;
            Weight = 2;
            Groups = new string[] { "Light Blade" };
            Properties = new string[] { "Off-Hand" };
        }
    }
}
