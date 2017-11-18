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

    }
}
