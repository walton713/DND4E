namespace DND4E.Items.Weapons
{
    public class ParryingDagger : Weapon
    {
        public ParryingDagger()
        {
            Name = "Parrying Dagger";
            DieSize = 4;
            Cost = 5;
            Weight = 1;
            Groups = new string[] { "Light Blade" };
            Properties = new string[] { "Defensive", "Off-Hand" };
        }
    }
}
