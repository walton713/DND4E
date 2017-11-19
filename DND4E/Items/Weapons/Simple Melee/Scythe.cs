namespace DND4E.Items.Weapons
{
    public class Scythe : Weapon
    {
        public Scythe()
        {
            Name = "Scythe";
            DieNumber = 2;
            DieSize = 4;
            Cost = 5;
            Weight = 10;
            Groups = new string[] { "Heavy Blade" };
            IsTwoHanded = true;
        }
    }
}
