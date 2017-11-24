namespace DND4E.Items.Weapons
{
    public class LightWarPick : Weapon
    {
        public LightWarPick()
        {
            Name = "Light War Pick";
            Cost = 10;
            Weight = 4;
            Groups = new string[] { "Pick" };
            Properties = new string[] { "High Crit", "Off-Hand" };
        }
    }
}
