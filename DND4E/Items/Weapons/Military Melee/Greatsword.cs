namespace DND4E.Items.Weapons
{
    public class Greatsword : Weapon
    {
        public Greatsword()
        {
            Name = "Greatsword";
            ProficiencyBonus = 3;
            DieSize = 10;
            Cost = 30;
            Weight = 8;
            Groups = new string[] { "Heavy Blade" };
            IsTwoHanded = true;
        }
    }
}
