namespace DND4E.Items.Weapons
{
    public class Maul : Weapon
    {
        public Maul()
        {
            Name = "Maul";
            DieNumber = 2;
            Cost = 30;
            Weight = 12;
            Groups = new string[] { "Hammer" };
            IsTwoHanded = true;
        }
    }
}
