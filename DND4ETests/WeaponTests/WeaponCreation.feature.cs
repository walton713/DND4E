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
        [NUnit.Framework.TestCaseAttribute("Club", "2", "1", "6", "1", "3", "Mace", "1", null)]
        public virtual void OneHandNoRangeOneGroupNoProperties(string weapon, string prof, string dienum, string diesize, string cost, string weight, string group, string quantity, string[] exampleTags)
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
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("OneHandWithRangeOneGroupTwoProperties")]
        [NUnit.Framework.TestCaseAttribute("Dagger", "3", "1", "4", "5", "10", "1", "1", "Light Blade", "Off-Hand", "Light Thrown", "1", null)]
        [NUnit.Framework.TestCaseAttribute("Handaxe", "2", "1", "6", "5", "10", "5", "3", "Axe", "Off-Hand", "Heavy Thrown", "1", null)]
        [NUnit.Framework.TestCaseAttribute("Throwing Hammer", "2", "1", "6", "5", "10", "5", "2", "Hammer", "Off-Hand", "Heavy Thrown", "1", null)]
        public virtual void OneHandWithRangeOneGroupTwoProperties(string weapon, string prof, string dienum, string diesize, string @short, string @long, string cost, string weight, string group, string prop1, string prop2, string quantity, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("OneHandWithRangeOneGroupTwoProperties", exampleTags);
#line 24
this.ScenarioSetup(scenarioInfo);
#line 25
 testRunner.Given(string.Format("I have a \"{0}\"", weapon), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 26
 testRunner.Then(string.Format("it has the name \"{0}\"", weapon), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 27
 testRunner.And(string.Format("a {0} proficiency bonus", prof), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 28
 testRunner.And(string.Format("a die number of {0}", dienum), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 29
 testRunner.And(string.Format("a die size of {0}", diesize), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 30
 testRunner.And(string.Format("a short range of {0}", @short), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 31
 testRunner.And(string.Format("a long range of {0}", @long), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 32
 testRunner.And(string.Format("a cost of {0}", cost), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 33
 testRunner.And(string.Format("a weight of {0}", weight), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 34
 testRunner.And(string.Format("a group of \"{0}\"", group), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 35
 testRunner.And(string.Format("the \"{0}\" property", prop1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 36
 testRunner.And(string.Format("the \"{0}\" property", prop2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 37
 testRunner.And("is One-Handed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 38
 testRunner.And(string.Format("a quantity of {0}", quantity), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("OneHandWithRangeOneGroupOneProperty")]
        [NUnit.Framework.TestCaseAttribute("Javelin", "2", "1", "6", "10", "20", "5", "2", "Spear", "Heavy Thrown", "1", null)]
        public virtual void OneHandWithRangeOneGroupOneProperty(string weapon, string prof, string dienum, string diesize, string @short, string @long, string cost, string weight, string group, string prop, string quantity, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("OneHandWithRangeOneGroupOneProperty", exampleTags);
#line 46
this.ScenarioSetup(scenarioInfo);
#line 47
 testRunner.Given(string.Format("I have a \"{0}\"", weapon), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 48
 testRunner.Then(string.Format("it has the name \"{0}\"", weapon), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 49
 testRunner.And(string.Format("a {0} proficiency bonus", prof), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 50
 testRunner.And(string.Format("a die number of {0}", dienum), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 51
 testRunner.And(string.Format("a die size of {0}", diesize), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 52
 testRunner.And(string.Format("a short range of {0}", @short), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 53
 testRunner.And(string.Format("a long range of {0}", @long), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 54
 testRunner.And(string.Format("a cost of {0}", cost), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 55
 testRunner.And(string.Format("a weight of {0}", weight), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 56
 testRunner.And(string.Format("a group of \"{0}\"", group), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 57
 testRunner.And(string.Format("the \"{0}\" property", prop), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 58
 testRunner.And("is One-Handed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 59
 testRunner.And(string.Format("a quantity of {0}", quantity), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("OneHandNoRangeOneGroupOneProperty")]
        [NUnit.Framework.TestCaseAttribute("Mace", "2", "1", "8", "5", "6", "Mace", "Versatile", "1", null)]
        [NUnit.Framework.TestCaseAttribute("Sickle", "2", "1", "6", "2", "2", "Light Blade", "Off-Hand", "1", null)]
        [NUnit.Framework.TestCaseAttribute("Spear", "2", "1", "8", "5", "6", "Spear", "Versatile", "1", null)]
        [NUnit.Framework.TestCaseAttribute("Battleaxe", "2", "1", "10", "15", "6", "Axe", "Versatile", "1", null)]
        [NUnit.Framework.TestCaseAttribute("Flail", "2", "1", "10", "10", "5", "Flail", "Versatile", "1", null)]
        [NUnit.Framework.TestCaseAttribute("Longsword", "3", "1", "8", "15", "4", "Heavy Blade", "Versatile", "1", null)]
        [NUnit.Framework.TestCaseAttribute("Scimitar", "2", "1", "8", "10", "4", "Heavy Blade", "High Crit", "1", null)]
        [NUnit.Framework.TestCaseAttribute("Short Sword", "3", "1", "6", "10", "2", "Light Blade", "Off-Hand", "1", null)]
        [NUnit.Framework.TestCaseAttribute("Warhammer", "2", "1", "10", "15", "5", "Hammer", "Versatile", "1", null)]
        public virtual void OneHandNoRangeOneGroupOneProperty(string weapon, string prof, string dienum, string diesize, string cost, string weight, string group, string prop, string quantity, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("OneHandNoRangeOneGroupOneProperty", exampleTags);
#line 65
this.ScenarioSetup(scenarioInfo);
#line 66
 testRunner.Given(string.Format("I have a \"{0}\"", weapon), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 67
 testRunner.Then(string.Format("it has the name \"{0}\"", weapon), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 68
 testRunner.And(string.Format("a {0} proficiency bonus", prof), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 69
 testRunner.And(string.Format("a die number of {0}", dienum), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 70
 testRunner.And(string.Format("a die size of {0}", diesize), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 71
 testRunner.And("no range", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 72
 testRunner.And(string.Format("a cost of {0}", cost), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 73
 testRunner.And(string.Format("a weight of {0}", weight), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 74
 testRunner.And(string.Format("a group of \"{0}\"", group), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 75
 testRunner.And(string.Format("the \"{0}\" property", prop), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 76
 testRunner.And("is One-Handed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 77
 testRunner.And(string.Format("a quantity of {0}", quantity), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("OneHandNoRangeOneGroupTwoProperties")]
        [NUnit.Framework.TestCaseAttribute("War Pick", "2", "1", "8", "15", "6", "Pick", "High Crit", "Versatile", "1", null)]
        public virtual void OneHandNoRangeOneGroupTwoProperties(string weapon, string prof, string dienum, string diesize, string cost, string weight, string group, string prop1, string prop2, string quantity, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("OneHandNoRangeOneGroupTwoProperties", exampleTags);
#line 91
this.ScenarioSetup(scenarioInfo);
#line 92
 testRunner.Given(string.Format("I have a \"{0}\"", weapon), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 93
 testRunner.Then(string.Format("it has the name \"{0}\"", weapon), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 94
 testRunner.And(string.Format("a {0} proficiency bonus", prof), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 95
 testRunner.And(string.Format("a die number of {0}", dienum), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 96
 testRunner.And(string.Format("a die size of {0}", diesize), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 97
 testRunner.And("no range", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 98
 testRunner.And(string.Format("a cost of {0}", cost), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 99
 testRunner.And(string.Format("a weight of {0}", weight), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 100
 testRunner.And(string.Format("a group of \"{0}\"", group), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 101
 testRunner.And(string.Format("the \"{0}\" property", prop1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 102
 testRunner.And(string.Format("the \"{0}\" property", prop2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 103
 testRunner.And("is One-Handed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 104
 testRunner.And(string.Format("a quantity of {0}", quantity), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("TwoHandNoRangeOneGroupNoProperties")]
        [NUnit.Framework.TestCaseAttribute("Greatclub", "2", "2", "4", "1", "10", "Mace", "1", null)]
        [NUnit.Framework.TestCaseAttribute("Morningstar", "2", "1", "10", "10", "8", "Mace", "1", null)]
        [NUnit.Framework.TestCaseAttribute("Quarterstaff", "2", "1", "8", "5", "4", "Staff", "1", null)]
        [NUnit.Framework.TestCaseAttribute("Scythe", "2", "2", "4", "5", "10", "Heavy Blade", "1", null)]
        public virtual void TwoHandNoRangeOneGroupNoProperties(string weapon, string prof, string dienum, string diesize, string cost, string weight, string group, string quantity, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("TwoHandNoRangeOneGroupNoProperties", exampleTags);
#line 110
this.ScenarioSetup(scenarioInfo);
#line 111
 testRunner.Given(string.Format("I have a \"{0}\"", weapon), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 112
 testRunner.Then(string.Format("it has the name \"{0}\"", weapon), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 113
 testRunner.And(string.Format("a {0} proficiency bonus", prof), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 114
 testRunner.And(string.Format("a die number of {0}", dienum), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 115
 testRunner.And(string.Format("a die size of {0}", diesize), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 116
 testRunner.And("no range", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 117
 testRunner.And(string.Format("a cost of {0}", cost), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 118
 testRunner.And(string.Format("a weight of {0}", weight), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 119
 testRunner.And(string.Format("a group of \"{0}\"", group), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 120
 testRunner.And("no properties", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 121
 testRunner.And("is Two-Handed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 122
 testRunner.And(string.Format("a quantity of {0}", quantity), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
