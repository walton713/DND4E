namespace DND4E.Items.Weapons
{
    public class Falchion : Weapon
    {
        public Falchion()
        {
            Name = "Falchion";
            ProficiencyBonus = 3;
            DieNumber = 2;
            DieSize = 4;
            Cost = 25;
            Weight = 7;
            Groups = new string[] { "Heavy Blade" };
            Properties = new string[] { "High Crit" };
            IsTwoHanded = true;
        }
    }
}
