namespace DND4E.Items.Weapons
{
    public class ThrowingHammer : Weapon
    {
        public ThrowingHammer()
        {
            Name = "Throwing Hammer";
            ShortRange = 5;
            LongRange = 10;
            Cost = 5;
            Weight = 2;
            Groups = new string[] { "Hammer" };
            Properties = new string[] { "Off-Hand", "Heavy Thrown" };
        }
    }
}
