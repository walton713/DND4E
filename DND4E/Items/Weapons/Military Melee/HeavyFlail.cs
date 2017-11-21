namespace DND4E.Items.Weapons
{
    public class HeavyFlail : Weapon
    {
        public HeavyFlail()
        {
            Name = "Heavy Flail";
            DieNumber = 2;
            Cost = 25;
            Weight = 10;
            Groups = new string[] { "Flail" };
            IsTwoHanded = true;
        }
    }
}
