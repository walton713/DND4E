using TechTalk.SpecFlow;

using DND4E.Items.Weapons;
using NUnit.Framework;

namespace DND4ETests.WeaponTests
{
    [Binding]
    public class WeaponCreationSteps
    {
        Weapon weapon;

        [Given(@"I have a ""(.*)""")]
        public void GivenIHaveA(string name)
        {
            switch (name)
            {
                case "Club":
                    weapon = new Club();
                    break;

                case "Dagger":
                    weapon = new Dagger();
                    break;

                case "Javelin":
                    weapon = new Javelin();
                    break;

                case "Mace":
                    weapon = new Mace();
                    break;

                case "Sickle":
                    weapon = new Sickle();
                    break;

                case "Spear":
                    weapon = new Spear();
                    break;

                case "Greatclub":
                    weapon = new Greatclub();
                    break;

                case "Morningstar":
                    weapon = new Morningstar();
                    break;

                case "Quarterstaff":
                    weapon = new Quarterstaff();
                    break;

                case "Scythe":
                    weapon = new Scythe();
                    break;

                case "Battleaxe":
                    weapon = new Battleaxe();
                    break;

                case "Flail":
                    weapon = new Flail();
                    break;

                case "Handaxe":
                    weapon = new Handaxe();
                    break;

                case "Longsword":
                    weapon = new Longsword();
                    break;

                case "Scimitar":
                    weapon = new Scimitar();
                    break;

                case "Short Sword":
                    weapon = new ShortSword();
                    break;

                case "Throwing Hammer":
                    weapon = new ThrowingHammer();
                    break;

                case "Warhammer":
                    weapon = new Warhammer();
                    break;

                case "War Pick":
                    weapon = new WarPick();
                    break;

                case "Falchion":
                    weapon = new Falchion();
                    break;

                case "Glaive":
                    weapon = new Glaive();
                    break;

                case "Greataxe":
                    weapon = new Greataxe();
                    break;

                case "Greatsword":
                    weapon = new Greatsword();
                    break;

                case "Halberd":
                    weapon = new Halberd();
                    break;

                case "Heavy Flail":
                    weapon = new HeavyFlail();
                    break;

                case "Longspear":
                    weapon = new Longspear();
                    break;

                case "Maul":
                    weapon = new Maul();
                    break;

                case "Bastard Sword":
                    weapon = new BastardSword();
                    break;

                case "Katar":
                    weapon = new Katar();
                    break;

                case "Rapier":
                    weapon = new Rapier();
                    break;

                case "Spiked Chain":
                    weapon = new SpikedChain();
                    break;

                case "Hand Crossbow":
                    weapon = new HandCrossbow();
                    break;

                case "Sling":
                    weapon = new Sling();
                    break;

                case "Crossbow":
                    weapon = new Crossbow();
                    break;

                default:
                    break;
            }
        }
        
        [Then(@"it has the name ""(.*)""")]
        public void ThenItHasTheName(string name)
        {
            Assert.That(weapon.Name, Is.EqualTo(name));
        }
        
        [Then(@"a (.*) proficiency bonus")]
        public void ThenAProficiencyBonus(int bonus)
        {
            Assert.That(weapon.ProficiencyBonus, Is.EqualTo(bonus));
        }
        
        [Then(@"a die number of (.*)")]
        public void ThenADieNumberOf(int dienum)
        {
            Assert.That(weapon.DieNumber, Is.EqualTo(dienum));
        }
        
        [Then(@"a die size of (.*)")]
        public void ThenADieSizeOf(int diesize)
        {
            Assert.That(weapon.DieSize, Is.EqualTo(diesize));
        }
        
        [Then(@"no range")]
        public void ThenNoRange()
        {
            Assert.That(weapon.ShortRange, Is.EqualTo(0));
            Assert.That(weapon.LongRange, Is.EqualTo(0));
        }
        
        [Then(@"a cost of (.*)")]
        public void ThenACostOf(decimal cost)
        {
            Assert.That(weapon.Cost, Is.EqualTo(cost));
        }
        
        [Then(@"a weight of (.*)")]
        public void ThenAWeightOf(decimal weight)
        {
            Assert.That(weapon.Weight, Is.EqualTo(weight));
        }

        [Then(@"a group of ""(.*)""")]
        public void ThenAGroupOf(string group)
        {
            Assert.That(weapon.Groups, Does.Contain(group));
        }

        [Then(@"no properties")]
        public void ThenNoProperties()
        {
            Assert.That(weapon.Properties, Is.Empty);
        }

        [Then(@"is One-Handed")]
        public void ThenIsOne_Handed()
        {
            Assert.That(weapon.IsTwoHanded, Is.False);
        }


        [Then(@"a short range of (.*)")]
        public void ThenAShortRangeOf(int range)
        {
            Assert.That(weapon.ShortRange, Is.EqualTo(range));
        }

        [Then(@"a long range of (.*)")]
        public void ThenALongRangeOf(int range)
        {
            Assert.That(weapon.LongRange, Is.EqualTo(range));
        }

        [Then(@"the ""(.*)"" property")]
        public void ThenTheProperty(string prop)
        {
            Assert.That(weapon.Properties, Does.Contain(prop));
        }

        [Then(@"is Two-Handed")]
        public void ThenIsTwo_Handed()
        {
            Assert.That(weapon.IsTwoHanded, Is.True);
        }

        [Then(@"a quantity of (.*)")]
        public void ThenAQuantityOf(int quantity)
        {
            Assert.That(weapon.Quantity, Is.EqualTo(quantity));
        }

        [Then(@"is ""(.*)""")]
        public void ThenIs(bool melee)
        {
            Assert.That(weapon.IsMelee, Is.EqualTo(melee));
        }
    }
}