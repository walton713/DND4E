namespace DND4E.Items.Weapons
{
    public class Rapier : Weapon
    {
        public Rapier()
        {
            Name = "Rapier";
            ProficiencyBonus = 3;
            DieSize = 8;
            Cost = 25;
            Weight = 2;
            Groups = new string[] { "Light Blade" };
        }
    }
}
