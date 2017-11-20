namespace DND4E.Items.Weapons
{
    public class Handaxe : Weapon
    {
        public Handaxe()
        {
            Name = "Handaxe";
            ShortRange = 5;
            LongRange = 10;
            Cost = 5;
            Weight = 3;
            Groups = new string[] { "Axe" };
            Properties = new string[] { "Off-Hand", "Heavy Thrown" };
        }
    }
}
