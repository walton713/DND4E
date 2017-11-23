namespace DND4E.Items.Weapons
{
    public class SpikedChain : Weapon
    {
        public SpikedChain()
        {
            Name = "Spiked Chain";
            ProficiencyBonus = 3;
            DieNumber = 2;
            DieSize = 4;
            Cost = 30;
            Weight = 10;
            Groups = new string[] { "Flail" };
            Properties = new string[] { "Reach" };
            IsTwoHanded = true;
        }
    }
}
