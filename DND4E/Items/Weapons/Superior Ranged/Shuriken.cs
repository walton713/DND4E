namespace DND4E.Items.Weapons
{
    public class Shuriken : Weapon
    {
        public Shuriken()
        {
            Name = "Shuriken";
            ProficiencyBonus = 3;
            DieSize = 4;
            ShortRange = 6;
            LongRange = 12;
            Cost = 1;
            Weight = 0.5M;
            Groups = new string[] { "Light Blade" };
            Properties = new string[] { "Light Thrown" };
            Quantity = 5;
            IsMelee = false;
        }
    }
}
