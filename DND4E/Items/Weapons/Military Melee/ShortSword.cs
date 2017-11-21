namespace DND4E.Items.Weapons
{
    public class ShortSword : Weapon
    {
        public ShortSword()
        {
            Name = "Short Sword";
            ProficiencyBonus = 3;
            Cost = 10;
            Weight = 2;
            Groups = new string[] { "Light Blade" };
            Properties = new string[] { "Off-Hand" };
        }
    }
}
