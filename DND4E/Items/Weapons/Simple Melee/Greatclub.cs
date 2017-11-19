namespace DND4E.Items.Weapons
{
    public class Greatclub : Weapon
    {
        public Greatclub()
        {
            Name = "Greatclub";
            DieNumber = 2;
            DieSize = 4;
            Cost = 1;
            Weight = 10;
            Groups = new string[] { "Mace" };
            IsTwoHanded = true;
        }
    }
}
