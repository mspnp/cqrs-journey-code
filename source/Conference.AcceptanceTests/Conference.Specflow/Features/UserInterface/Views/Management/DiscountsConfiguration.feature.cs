﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.8.1.0
//      SpecFlow Generator Version:1.8.0.0
//      Runtime Version:4.0.30319.269
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Conference.Specflow.Features.UserInterface.Views.Management
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.8.1.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class PromotionalCodesConfigurationScenariosForCreatingAndEditingPromotionalCodesSettingsFeature : Xunit.IUseFixture<PromotionalCodesConfigurationScenariosForCreatingAndEditingPromotionalCodesSettingsFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "DiscountsConfiguration.feature"
#line hidden
        
        public PromotionalCodesConfigurationScenariosForCreatingAndEditingPromotionalCodesSettingsFeature()
        {
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Promotional Codes configuration scenarios for creating and editing Promotional Co" +
                    "des settings", "In order to create or update a Promotional Code\r\nAs a Business Customer\r\nI want t" +
                    "o be able to create or update a Promotional Code and set its properties", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
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
        
        public virtual void FeatureBackground()
        {
#line 19
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Promotional Code",
                        "Discount",
                        "Quota",
                        "Scope",
                        "Cumulative"});
            table1.AddRow(new string[] {
                        "SPEAKER123",
                        "100%",
                        "Unlimited",
                        "All",
                        ""});
#line 20
testRunner.Given("the Promotional Codes", ((string)(null)), table1);
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "seat type",
                        "quota"});
            table2.AddRow(new string[] {
                        "General admission",
                        "500"});
            table2.AddRow(new string[] {
                        "CQRS Workshop",
                        "100"});
            table2.AddRow(new string[] {
                        "Additional cocktail party",
                        "600"});
#line 23
testRunner.And("the Seat Types configuration", ((string)(null)), table2);
#line hidden
        }
        
        public virtual void SetFixture(PromotionalCodesConfigurationScenariosForCreatingAndEditingPromotionalCodesSettingsFeature.FixtureData fixtureData)
        {
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [Xunit.FactAttribute(Skip="Ignored")]
        [Xunit.TraitAttribute("FeatureTitle", "Promotional Codes configuration scenarios for creating and editing Promotional Co" +
            "des settings")]
        [Xunit.TraitAttribute("Description", "Create a new Promotional Code")]
        public virtual void CreateANewPromotionalCode()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create a new Promotional Code", new string[] {
                        "Ignore"});
#line 32
this.ScenarioSetup(scenarioInfo);
#line 19
this.FeatureBackground();
#line 33
testRunner.Given("the Business Customer proceed to create a Promotional Code");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Discount",
                        "Quota",
                        "Scope",
                        "Cumulative"});
            table3.AddRow(new string[] {
                        "10%",
                        "Unlimited",
                        "General admission",
                        "SPEAKER123"});
#line 34
testRunner.And("the Business Customer enter the \'NEWCODE\' Promotional Code and these attributes", ((string)(null)), table3);
#line 37
testRunner.When("the Business Customer proceed to save the new information");
#line 38
testRunner.Then("the new Promotional Code is added to the list of existing codes");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(Skip="Ignored")]
        [Xunit.TraitAttribute("FeatureTitle", "Promotional Codes configuration scenarios for creating and editing Promotional Co" +
            "des settings")]
        [Xunit.TraitAttribute("Description", "Create a new Promotional Code with with exceeding quota")]
        public virtual void CreateANewPromotionalCodeWithWithExceedingQuota()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create a new Promotional Code with with exceeding quota", new string[] {
                        "Ignore"});
#line 44
this.ScenarioSetup(scenarioInfo);
#line 19
this.FeatureBackground();
#line 45
testRunner.Given("the Business Customer proceed to create a Promotional Code");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Discount",
                        "Quota",
                        "Scope",
                        "Cumulative"});
            table4.AddRow(new string[] {
                        "10%",
                        "1000",
                        "General admission",
                        "SPEAKER123"});
#line 46
testRunner.And("the Business Customer enter the \'NEWCODE\' Promotional Code and these attributes", ((string)(null)), table4);
#line 49
testRunner.When("the Business Customer proceed to save the new information");
#line 50
testRunner.Then("an error message will show up describing that the quota value exceeds the total s" +
                    "eats for the specified Seat Type");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(Skip="Ignored")]
        [Xunit.TraitAttribute("FeatureTitle", "Promotional Codes configuration scenarios for creating and editing Promotional Co" +
            "des settings")]
        [Xunit.TraitAttribute("Description", "Update an existing Promotional Code")]
        public virtual void UpdateAnExistingPromotionalCode()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Update an existing Promotional Code", new string[] {
                        "Ignore"});
#line 56
this.ScenarioSetup(scenarioInfo);
#line 19
this.FeatureBackground();
#line 57
testRunner.Given("the Business Customer selects \'SPEAKER123\' Promotional Code");
#line 58
testRunner.And("the Scope is updated with value \'CQRS Workshop\'");
#line 59
testRunner.And("the Quota is updated with the value \'50\'");
#line 60
testRunner.When("the Business Customer proceed to save the new information");
#line 61
testRunner.Then("updated values are reflected in the selected Promotional Code");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(Skip="Ignored")]
        [Xunit.TraitAttribute("FeatureTitle", "Promotional Codes configuration scenarios for creating and editing Promotional Co" +
            "des settings")]
        [Xunit.TraitAttribute("Description", "Update an existing Promotional Code with exceeding quota")]
        public virtual void UpdateAnExistingPromotionalCodeWithExceedingQuota()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Update an existing Promotional Code with exceeding quota", new string[] {
                        "Ignore"});
#line 67
this.ScenarioSetup(scenarioInfo);
#line 19
this.FeatureBackground();
#line 68
testRunner.Given("the Business Customer selects \'SPEAKER123\' Promotional Code");
#line 69
testRunner.And("the Scope is updated with value \'CQRS Workshop\'");
#line 70
testRunner.And("the Quota is updated with the value \'200\'");
#line 71
testRunner.When("the Business Customer proceed to save the new information");
#line 72
testRunner.Then("an error message will show up describing that the quota value exceeds the total s" +
                    "eats for the specified Seat Type");
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.8.1.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                PromotionalCodesConfigurationScenariosForCreatingAndEditingPromotionalCodesSettingsFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                PromotionalCodesConfigurationScenariosForCreatingAndEditingPromotionalCodesSettingsFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
