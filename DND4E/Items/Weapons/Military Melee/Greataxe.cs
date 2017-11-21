namespace DND4E.Items.Weapons
{
    public class Greataxe : Weapon
    {
        public Greataxe()
        {
            Name = "Greataxe";
            DieSize = 12;
            Cost = 30;
            Weight = 12;
            Groups = new string[] { "Axe" };
            Properties = new string[] { "High Crit" };
            IsTwoHanded = true;
        }
    }
}
