namespace DND4E.Items.Weapons
{
    public class SpikedGauntlet : Weapon
    {
        public SpikedGauntlet()
        {
            Name = "Spiked Gauntlet";
            Cost = 5;
            Weight = 1;
            Groups = new string[] { "Unarmed" };
            Properties = new string[] { "Off-Hand" };
        }
    }
}
