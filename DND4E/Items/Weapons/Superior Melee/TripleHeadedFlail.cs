namespace DND4E.Items.Weapons
{
    public class TripleHeadedFlail : Weapon
    {
        public TripleHeadedFlail()
        {
            Name = "Triple-Headed Flail";
            ProficiencyBonus = 3;
            DieSize = 10;
            Cost = 15;
            Weight = 6;
            Groups = new string[] { "Flail" };
            Properties = new string[] { "Versatile" };
        }
    }
}
