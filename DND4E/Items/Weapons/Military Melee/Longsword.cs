namespace DND4E.Items.Weapons
{
    public class Longsword : Weapon
    {
        public Longsword()
        {
            Name = "Longsword";
            ProficiencyBonus = 3;
            DieSize = 8;
            Cost = 15;
            Weight = 4;
            Groups = new string[] { "Heavy Blade" };
            Properties = new string[] { "Versatile" };
        }
    }
}
