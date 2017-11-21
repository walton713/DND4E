namespace DND4E.Items.Weapons
{
    public class Longspear : Weapon
    {
        public Longspear()
        {
            Name = "Longspear";
            DieSize = 10;
            Cost = 10;
            Weight = 9;
            Groups = new string[] { "Spear", "Polearm" };
            Properties = new string[] { "Reach" };
            IsTwoHanded = true;
        }
    }
}
