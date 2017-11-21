namespace DND4E.Items.Weapons
{
    public class Halberd : Weapon
    {
        public Halberd()
        {
            Name = "Halberd";
            DieSize = 10;
            Cost = 25;
            Weight = 12;
            Groups = new string[] { "Axe", "Polearm" };
            Properties = new string[] { "Reach" };
            IsTwoHanded = true;
        }
    }
}
