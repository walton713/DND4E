namespace DND4E.Items.Weapons
{
    public class Morningstar : Weapon
    {
        public Morningstar()
        {
            Name = "Morningstar";
            DieSize = 10;
            Cost = 10;
            Weight = 8;
            Groups = new string[] { "Mace" };
            IsTwoHanded = true;
        }
    }
}
