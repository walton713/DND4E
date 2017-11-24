namespace DND4E.Items.Weapons
{
    public class Longbow : Weapon
    {
        public Longbow()
        {
            Name = "Longbow";
            DieSize = 10;
            ShortRange = 20;
            LongRange = 40;
            Cost = 30;
            Weight = 3;
            Groups = new string[] { "Bow" };
            Properties = new string[] { "Load Free" };
            IsTwoHanded = true;
            IsMelee = false;
        }
    }
}
