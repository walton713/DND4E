namespace DND4E.Items.Weapons
{
    public class Crossbow : Weapon
    {
        public Crossbow()
        {
            Name = "Crossbow";
            DieSize = 8;
            ShortRange = 15;
            LongRange = 30;
            Cost = 25;
            Weight = 4;
            Groups = new string[] { "Crossbow" };
            Properties = new string[] { "Load Minor" };
            IsTwoHanded = true;
            IsMelee = false;
        }
    }
}
