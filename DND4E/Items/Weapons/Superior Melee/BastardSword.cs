namespace DND4E.Items.Weapons
{
    public class BastardSword : Weapon
    {
        public BastardSword()
        {
            Name = "Bastard Sword";
            ProficiencyBonus = 3;
            DieSize = 10;
            Cost = 30;
            Weight = 6;
            Groups = new string[] { "Heavy Blade" };
            Properties = new string[] { "Versatile" };
        }
    }
}
