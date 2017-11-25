namespace DND4E.Items.Weapons
{
    public class HeavyWarPick : Weapon
    {
        public HeavyWarPick()
        {
            Name = "Heavy War Pick";
            DieSize = 12;
            Cost = 20;
            Weight = 8;
            Groups = new string[] { "Pick" };
            Properties = new string[] { "High Crit" };
            IsTwoHanded = true;
        }
    }
}
