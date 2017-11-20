namespace DND4E.Items.Weapons
{
    public class Weapon
    {
        public string Name { get; set; }
        public string[] Groups { get; set; } = new string[] { };
        public string[] Properties { get; set; } = new string[] { };
        public int ProficiencyBonus { get; set; } = 2;
        public int DieNumber { get; set; } = 1;
        public int DieSize { get; set; } = 6;
        public int ShortRange { get; set; } = 0;
        public int LongRange { get; set; } = 0;
        public int Quantity { get; set; } = 1;
        public decimal Cost { get; set; }
        public decimal Weight { get; set; }
        public bool IsTwoHanded { get; set; }
    }
}