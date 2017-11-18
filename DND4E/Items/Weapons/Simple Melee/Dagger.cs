namespace DND4E.Items.Weapons
{
    public class Dagger : Weapon
    {
        public Dagger()
        {
            Name = "Dagger";
            ProficiencyBonus = 3;
            DieSize = 4;
            ShortRange = 5;
            LongRange = 10;
            Cost = 1;
            Weight = 1;
            Groups = new string[] { "Light Blade" };
            Properties = new string[] { "Off-Hand", "Light Thrown" };
        }
    }
}
