namespace DND4E.Items.Weapons
{
    public class Katar : Weapon
    {
        public Katar()
        {
            Name = "Katar";
            ProficiencyBonus = 3;
            Cost = 3;
            Weight = 1;
            Groups = new string[] { "Light Blade" };
            Properties = new string[] { "Off-Hand", "High Crit" };
        }
    }
}
