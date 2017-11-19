namespace DND4E.Items.Weapons
{
    public class Quarterstaff : Weapon
    {
        public Quarterstaff()
        {
            Name = "Quarterstaff";
            DieSize = 8;
            Cost = 5;
            Weight = 4;
            Groups = new string[] { "Staff" };
            IsTwoHanded = true;
        }
    }
}
