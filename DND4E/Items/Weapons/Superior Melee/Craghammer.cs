namespace DND4E.Items.Weapons
{
    public class Craghammer : Weapon
    {
        public Craghammer()
        {
            Name = "Craghammer";
            DieSize = 10;
            Cost = 20;
            Weight = 6;
            Groups = new string[] { "Hammer" };
            Properties = new string[] { "Brutal 2", "Versatile" };
        }
    }
}
