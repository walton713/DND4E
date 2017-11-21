namespace DND4E.Items.Weapons
{
    public class Glaive : Weapon
    {
        public Glaive()
        {
            Name = "Glaive";
            DieNumber = 2;
            DieSize = 4;
            Cost = 25;
            Weight = 10;
            Groups = new string[] { "Heavy Blade", "Polearm" };
            Properties = new string[] { "Reach" };
            IsTwoHanded = true;
        }
    }
}
