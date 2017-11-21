namespace DND4E.Items.Weapons
{
    public class Warhammer : Weapon
    {
        public Warhammer()
        {
            Name = "Warhammer";
            DieSize = 10;
            Cost = 15;
            Weight = 5;
            Groups = new string[] { "Hammer" };
            Properties = new string[] { "Versatile" };
        }
    }
}
