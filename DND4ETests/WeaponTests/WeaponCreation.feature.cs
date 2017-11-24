﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.2.0.0
//      SpecFlow Generator Version:2.2.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace DND4ETests.WeaponTests
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.2.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("WeaponCreation")]
    public partial class WeaponCreationFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "WeaponCreation.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "WeaponCreation", "\tAs a player\r\n\tI want to have weapons\r\n\tSo that I can vanquish my foes", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("OneHandNoRangeOneGroupNoProperties")]
        [NUnit.Framework.TestCaseAttribute("Club", "2", "1", "6", "1", "3", "Mace", "1", "true", null)]
        [NUnit.Framework.TestCaseAttribute("Rapier", "3", "1", "8", "25", "2", "Light Blade", "1", "true", null)]
        public virtual void OneHandNoRangeOneGroupNoProperties(string weapon, string prof, string dienum, string diesize, string cost, string weight, string group, string quantity, string melee, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("OneHandNoRangeOneGroupNoProperties", exampleTags);
#line 6
this.ScenarioSetup(scenarioInfo);
#line 7
 testRunner.Given(string.Format("I have a \"{0}\"", weapon), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 8
 testRunner.Then(string.Format("it has the name \"{0}\"", weapon), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 9
 testRunner.And(string.Format("a {0} proficiency bonus", prof), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 10
 testRunner.And(string.Format("a die number of {0}", dienum), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 11
 testRunner.And(string.Format("a die size of {0}", diesize), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 12
 testRunner.And("no range", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 13
 testRunner.And(string.Format("a cost of {0}", cost), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 14
 testRunner.And(string.Format("a weight of {0}", weight), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 15
 testRunner.And(string.Format("a group of \"{0}\"", group), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 16
 testRunner.And("no properties", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 17
 testRunner.And("is One-Handed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 18
 testRunner.And(string.Format("a quantity of {0}", quantity), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 19
 testRunner.And(string.Format("is \"{0}\"", melee), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("OneHandWithRangeOneGroupTwoProperties")]
        [NUnit.Framework.TestCaseAttribute("Dagger", "3", "1", "4", "5", "10", "1", "1", "Light Blade", "Off-Hand", "Light Thrown", "1", "true", null)]
        [NUnit.Framework.TestCaseAttribute("Handaxe", "2", "1", "6", "5", "10", "5", "3", "Axe", "Off-Hand", "Heavy Thrown", "1", "true", null)]
        [NUnit.Framework.TestCaseAttribute("Throwing Hammer", "2", "1", "6", "5", "10", "5", "2", "Hammer", "Off-Hand", "Heavy Thrown", "1", "true", null)]
        public virtual void OneHandWithRangeOneGroupTwoProperties(string weapon, string prof, string dienum, string diesize, string @short, string @long, string cost, string weight, string group, string prop1, string prop2, string quantity, string melee, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("OneHandWithRangeOneGroupTwoProperties", exampleTags);
#line 26
this.ScenarioSetup(scenarioInfo);
#line 27
 testRunner.Given(string.Format("I have a \"{0}\"", weapon), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 28
 testRunner.Then(string.Format("it has the name \"{0}\"", weapon), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 29
 testRunner.And(string.Format("a {0} proficiency bonus", prof), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 30
 testRunner.And(string.Format("a die number of {0}", dienum), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 31
 testRunner.And(string.Format("a die size of {0}", diesize), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 32
 testRunner.And(string.Format("a short range of {0}", @short), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 33
 testRunner.And(string.Format("a long range of {0}", @long), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 34
 testRunner.And(string.Format("a cost of {0}", cost), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 35
 testRunner.And(string.Format("a weight of {0}", weight), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 36
 testRunner.And(string.Format("a group of \"{0}\"", group), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 37
 testRunner.And(string.Format("the \"{0}\" property", prop1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 38
 testRunner.And(string.Format("the \"{0}\" property", prop2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 39
 testRunner.And("is One-Handed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 40
 testRunner.And(string.Format("a quantity of {0}", quantity), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 41
 testRunner.And(string.Format("is \"{0}\"", melee), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("OneHandWithRangeOneGroupOneProperty")]
        [NUnit.Framework.TestCaseAttribute("Javelin", "2", "1", "6", "10", "20", "5", "2", "Spear", "Heavy Thrown", "1", "true", null)]
        [NUnit.Framework.TestCaseAttribute("Hand Crossbow", "2", "1", "6", "10", "20", "25", "2", "Crossbow", "Load Free", "1", "false", null)]
        [NUnit.Framework.TestCaseAttribute("Sling", "2", "1", "6", "10", "20", "1", "0", "Sling", "Load Free", "1", "false", null)]
        [NUnit.Framework.TestCaseAttribute("Shuriken", "3", "1", "4", "6", "12", "1", "0.5", "Light Blade", "Light Thrown", "5", "false", null)]
        public virtual void OneHandWithRangeOneGroupOneProperty(string weapon, string prof, string dienum, string diesize, string @short, string @long, string cost, string weight, string group, string prop, string quantity, string melee, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("OneHandWithRangeOneGroupOneProperty", exampleTags);
#line 49
this.ScenarioSetup(scenarioInfo);
#line 50
 testRunner.Given(string.Format("I have a \"{0}\"", weapon), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 51
 testRunner.Then(string.Format("it has the name \"{0}\"", weapon), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 52
 testRunner.And(string.Format("a {0} proficiency bonus", prof), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 53
 testRunner.And(string.Format("a die number of {0}", dienum), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 54
 testRunner.And(string.Format("a die size of {0}", diesize), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 55
 testRunner.And(string.Format("a short range of {0}", @short), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 56
 testRunner.And(string.Format("a long range of {0}", @long), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 57
 testRunner.And(string.Format("a cost of {0}", cost), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 58
 testRunner.And(string.Format("a weight of {0}", weight), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 59
 testRunner.And(string.Format("a group of \"{0}\"", group), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 60
 testRunner.And(string.Format("the \"{0}\" property", prop), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 61
 testRunner.And("is One-Handed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 62
 testRunner.And(string.Format("a quantity of {0}", quantity), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 63
 testRunner.And(string.Format("is \"{0}\"", melee), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("OneHandNoRangeOneGroupOneProperty")]
        [NUnit.Framework.TestCaseAttribute("Mace", "2", "1", "8", "5", "6", "Mace", "Versatile", "1", "true", null)]
        [NUnit.Framework.TestCaseAttribute("Sickle", "2", "1", "6", "2", "2", "Light Blade", "Off-Hand", "1", "true", null)]
        [NUnit.Framework.TestCaseAttribute("Spear", "2", "1", "8", "5", "6", "Spear", "Versatile", "1", "true", null)]
        [NUnit.Framework.TestCaseAttribute("Battleaxe", "2", "1", "10", "15", "6", "Axe", "Versatile", "1", "true", null)]
        [NUnit.Framework.TestCaseAttribute("Flail", "2", "1", "10", "10", "5", "Flail", "Versatile", "1", "true", null)]
        [NUnit.Framework.TestCaseAttribute("Longsword", "3", "1", "8", "15", "4", "Heavy Blade", "Versatile", "1", "true", null)]
        [NUnit.Framework.TestCaseAttribute("Scimitar", "2", "1", "8", "10", "4", "Heavy Blade", "High Crit", "1", "true", null)]
        [NUnit.Framework.TestCaseAttribute("Short Sword", "3", "1", "6", "10", "2", "Light Blade", "Off-Hand", "1", "true", null)]
        [NUnit.Framework.TestCaseAttribute("Warhammer", "2", "1", "10", "15", "5", "Hammer", "Versatile", "1", "true", null)]
        [NUnit.Framework.TestCaseAttribute("Bastard Sword", "3", "1", "10", "30", "6", "Heavy Blade", "Versatile", "1", "true", null)]
        [NUnit.Framework.TestCaseAttribute("Spiked Gauntlet", "2", "1", "6", "5", "1", "Unarmed", "Off-Hand", "1", "true", null)]
        public virtual void OneHandNoRangeOneGroupOneProperty(string weapon, string prof, string dienum, string diesize, string cost, string weight, string group, string prop, string quantity, string melee, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("OneHandNoRangeOneGroupOneProperty", exampleTags);
#line 72
this.ScenarioSetup(scenarioInfo);
#line 73
 testRunner.Given(string.Format("I have a \"{0}\"", weapon), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 74
 testRunner.Then(string.Format("it has the name \"{0}\"", weapon), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 75
 testRunner.And(string.Format("a {0} proficiency bonus", prof), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 76
 testRunner.And(string.Format("a die number of {0}", dienum), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 77
 testRunner.And(string.Format("a die size of {0}", diesize), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 78
 testRunner.And("no range", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 79
 testRunner.And(string.Format("a cost of {0}", cost), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 80
 testRunner.And(string.Format("a weight of {0}", weight), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 81
 testRunner.And(string.Format("a group of \"{0}\"", group), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 82
 testRunner.And(string.Format("the \"{0}\" property", prop), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 83
 testRunner.And("is One-Handed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 84
 testRunner.And(string.Format("a quantity of {0}", quantity), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 85
 testRunner.And(string.Format("is \"{0}\"", melee), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("OneHandNoRangeOneGroupTwoProperties")]
        [NUnit.Framework.TestCaseAttribute("War Pick", "2", "1", "8", "15", "6", "Pick", "High Crit", "Versatile", "1", "true", null)]
        [NUnit.Framework.TestCaseAttribute("Katar", "3", "1", "6", "3", "1", "Light Blade", "Off-Hand", "High Crit", "1", "true", null)]
        public virtual void OneHandNoRangeOneGroupTwoProperties(string weapon, string prof, string dienum, string diesize, string cost, string weight, string group, string prop1, string prop2, string quantity, string melee, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("OneHandNoRangeOneGroupTwoProperties", exampleTags);
#line 101
this.ScenarioSetup(scenarioInfo);
#line 102
 testRunner.Given(string.Format("I have a \"{0}\"", weapon), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 103
 testRunner.Then(string.Format("it has the name \"{0}\"", weapon), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 104
 testRunner.And(string.Format("a {0} proficiency bonus", prof), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 105
 testRunner.And(string.Format("a die number of {0}", dienum), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 106
 testRunner.And(string.Format("a die size of {0}", diesize), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 107
 testRunner.And("no range", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 108
 testRunner.And(string.Format("a cost of {0}", cost), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 109
 testRunner.And(string.Format("a weight of {0}", weight), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 110
 testRunner.And(string.Format("a group of \"{0}\"", group), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 111
 testRunner.And(string.Format("the \"{0}\" property", prop1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 112
 testRunner.And(string.Format("the \"{0}\" property", prop2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 113
 testRunner.And("is One-Handed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 114
 testRunner.And(string.Format("a quantity of {0}", quantity), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 115
 testRunner.And(string.Format("is \"{0}\"", melee), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("TwoHandNoRangeOneGroupNoProperties")]
        [NUnit.Framework.TestCaseAttribute("Greatclub", "2", "2", "4", "1", "10", "Mace", "1", "true", null)]
        [NUnit.Framework.TestCaseAttribute("Morningstar", "2", "1", "10", "10", "8", "Mace", "1", "true", null)]
        [NUnit.Framework.TestCaseAttribute("Quarterstaff", "2", "1", "8", "5", "4", "Staff", "1", "true", null)]
        [NUnit.Framework.TestCaseAttribute("Scythe", "2", "2", "4", "5", "10", "Heavy Blade", "1", "true", null)]
        [NUnit.Framework.TestCaseAttribute("Greatsword", "3", "1", "10", "30", "8", "Heavy Blade", "1", "true", null)]
        [NUnit.Framework.TestCaseAttribute("Heavy Flail", "2", "2", "6", "25", "10", "Flail", "1", "true", null)]
        [NUnit.Framework.TestCaseAttribute("Maul", "2", "2", "6", "30", "12", "Hammer", "1", "true", null)]
        public virtual void TwoHandNoRangeOneGroupNoProperties(string weapon, string prof, string dienum, string diesize, string cost, string weight, string group, string quantity, string melee, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("TwoHandNoRangeOneGroupNoProperties", exampleTags);
#line 122
this.ScenarioSetup(scenarioInfo);
#line 123
 testRunner.Given(string.Format("I have a \"{0}\"", weapon), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 124
 testRunner.Then(string.Format("it has the name \"{0}\"", weapon), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 125
 testRunner.And(string.Format("a {0} proficiency bonus", prof), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 126
 testRunner.And(string.Format("a die number of {0}", dienum), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 127
 testRunner.And(string.Format("a die size of {0}", diesize), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 128
 testRunner.And("no range", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 129
 testRunner.And(string.Format("a cost of {0}", cost), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 130
 testRunner.And(string.Format("a weight of {0}", weight), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 131
 testRunner.And(string.Format("a group of \"{0}\"", group), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 132
 testRunner.And("no properties", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 133
 testRunner.And("is Two-Handed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 134
 testRunner.And(string.Format("a quantity of {0}", quantity), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 135
 testRunner.And(string.Format("is \"{0}\"", melee), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("TwoHandNoRangeOneGroupOneProperty")]
        [NUnit.Framework.TestCaseAttribute("Falchion", "3", "2", "4", "25", "7", "Heavy Blade", "High Crit", "1", "true", null)]
        [NUnit.Framework.TestCaseAttribute("Greataxe", "2", "1", "12", "30", "12", "Axe", "High Crit", "1", "true", null)]
        [NUnit.Framework.TestCaseAttribute("Spiked Chain", "3", "2", "4", "30", "10", "Flail", "Reach", "1", "true", null)]
        public virtual void TwoHandNoRangeOneGroupOneProperty(string weapon, string prof, string dienum, string diesize, string cost, string weight, string group, string prop, string quantity, string melee, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("TwoHandNoRangeOneGroupOneProperty", exampleTags);
#line 147
this.ScenarioSetup(scenarioInfo);
#line 148
 testRunner.Given(string.Format("I have a \"{0}\"", weapon), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 149
 testRunner.Then(string.Format("it has the name \"{0}\"", weapon), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 150
 testRunner.And(string.Format("a {0} proficiency bonus", prof), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 151
 testRunner.And(string.Format("a die number of {0}", dienum), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 152
 testRunner.And(string.Format("a die size of {0}", diesize), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 153
 testRunner.And("no range", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 154
 testRunner.And(string.Format("a cost of {0}", cost), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 155
 testRunner.And(string.Format("a weight of {0}", weight), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 156
 testRunner.And(string.Format("a group of \"{0}\"", group), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 157
 testRunner.And(string.Format("the \"{0}\" property", prop), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 158
 testRunner.And("is Two-Handed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 159
 testRunner.And(string.Format("a quantity of {0}", quantity), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 160
 testRunner.And(string.Format("is \"{0}\"", melee), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("TwoHandNoRangeTwoGroupsOneProperty")]
        [NUnit.Framework.TestCaseAttribute("Glaive", "2", "2", "4", "25", "10", "Heavy Blade", "Polearm", "Reach", "1", "true", null)]
        [NUnit.Framework.TestCaseAttribute("Halberd", "2", "1", "10", "25", "12", "Axe", "Polearm", "Reach", "1", "true", null)]
        [NUnit.Framework.TestCaseAttribute("Longspear", "2", "1", "10", "10", "9", "Spear", "Polearm", "Reach", "1", "true", null)]
        public virtual void TwoHandNoRangeTwoGroupsOneProperty(string weapon, string prof, string dienum, string diesize, string cost, string weight, string group1, string group2, string prop, string quantity, string melee, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("TwoHandNoRangeTwoGroupsOneProperty", exampleTags);
#line 168
this.ScenarioSetup(scenarioInfo);
#line 169
 testRunner.Given(string.Format("I have a \"{0}\"", weapon), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 170
 testRunner.Then(string.Format("it has the name \"{0}\"", weapon), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 171
 testRunner.And(string.Format("a {0} proficiency bonus", prof), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 172
 testRunner.And(string.Format("a die number of {0}", dienum), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 173
 testRunner.And(string.Format("a die size of {0}", diesize), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 174
 testRunner.And("no range", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 175
 testRunner.And(string.Format("a cost of {0}", cost), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 176
 testRunner.And(string.Format("a weight of {0}", weight), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 177
 testRunner.And(string.Format("a group of \"{0}\"", group1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 178
 testRunner.And(string.Format("a group of \"{0}\"", group2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 179
 testRunner.And(string.Format("the \"{0}\" property", prop), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 180
 testRunner.And("is Two-Handed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 181
 testRunner.And(string.Format("a quantity of {0}", quantity), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 182
 testRunner.And(string.Format("is \"{0}\"", melee), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("TwoHandWithRangeOneGroupOneProperty")]
        [NUnit.Framework.TestCaseAttribute("Crossbow", "2", "1", "8", "15", "30", "25", "4", "Crossbow", "Load Minor", "1", "false", null)]
        [NUnit.Framework.TestCaseAttribute("Longbow", "2", "1", "10", "20", "40", "30", "3", "Bow", "Load Free", "1", "false", null)]
        public virtual void TwoHandWithRangeOneGroupOneProperty(string weapon, string prof, string dienum, string diesize, string @short, string @long, string cost, string weight, string group, string prop, string quantity, string melee, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("TwoHandWithRangeOneGroupOneProperty", exampleTags);
#line 190
this.ScenarioSetup(scenarioInfo);
#line 191
 testRunner.Given(string.Format("I have a \"{0}\"", weapon), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 192
 testRunner.Then(string.Format("it has the name \"{0}\"", weapon), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 193
 testRunner.And(string.Format("a {0} proficiency bonus", prof), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 194
 testRunner.And(string.Format("a die number of {0}", dienum), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 195
 testRunner.And(string.Format("a die size of {0}", diesize), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 196
 testRunner.And(string.Format("a short range of {0}", @short), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 197
 testRunner.And(string.Format("a long range of {0}", @long), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 198
 testRunner.And(string.Format("a cost of {0}", cost), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 199
 testRunner.And(string.Format("a weight of {0}", weight), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 200
 testRunner.And(string.Format("a group of \"{0}\"", group), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 201
 testRunner.And(string.Format("the \"{0}\" property", prop), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 202
 testRunner.And("is Two-Handed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 203
 testRunner.And(string.Format("a quantity of {0}", quantity), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 204
 testRunner.And(string.Format("is \"{0}\"", melee), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("TwoHandWithRangeOneGroupTwoProperties")]
        [NUnit.Framework.TestCaseAttribute("Shortbow", "2", "1", "8", "15", "30", "25", "2", "Bow", "Load Free", "Small", "1", "false", null)]
        public virtual void TwoHandWithRangeOneGroupTwoProperties(string weapon, string prof, string dienum, string diesize, string @short, string @long, string cost, string weight, string group, string prop1, string prop2, string quantity, string melee, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("TwoHandWithRangeOneGroupTwoProperties", exampleTags);
#line 211
this.ScenarioSetup(scenarioInfo);
#line 212
 testRunner.Given(string.Format("I have a \"{0}\"", weapon), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 213
 testRunner.Then(string.Format("it has the name \"{0}\"", weapon), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 214
 testRunner.And(string.Format("a {0} proficiency bonus", prof), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 215
 testRunner.And(string.Format("a die number of {0}", dienum), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 216
 testRunner.And(string.Format("a die size of {0}", diesize), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 217
 testRunner.And(string.Format("a short range of {0}", @short), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 218
 testRunner.And(string.Format("a long range of {0}", @long), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 219
 testRunner.And(string.Format("a cost of {0}", cost), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 220
 testRunner.And(string.Format("a weight of {0}", weight), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 221
 testRunner.And(string.Format("a group of \"{0}\"", group), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 222
 testRunner.And(string.Format("the \"{0}\" property", prop1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 223
 testRunner.And(string.Format("the \"{0}\" property", prop2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 224
 testRunner.And("is Two-Handed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 225
 testRunner.And(string.Format("a quantity of {0}", quantity), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 226
 testRunner.And(string.Format("is \"{0}\"", melee), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
