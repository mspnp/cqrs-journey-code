﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.8.1.0
//      SpecFlow Generator Version:1.8.0.0
//      Runtime Version:4.0.30319.261
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Conference.Specflow.Features.Registration.AllFeaturesEndToEnd
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.8.1.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class RegistrantWorkflowForRegisteringAGroupOfAttendeesForAConferenceSadPathFeature : Xunit.IUseFixture<RegistrantWorkflowForRegisteringAGroupOfAttendeesForAConferenceSadPathFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "GroupRegistrationEndToEndSad.feature"
#line hidden
        
        public RegistrantWorkflowForRegisteringAGroupOfAttendeesForAConferenceSadPathFeature()
        {
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Registrant workflow for registering a group of Attendees for a conference (sad pa" +
                    "th)", "In order to register for conference a group of Attendees\r\nAs a Registrant\r\nI want" +
                    " to be able to select Order Items from one or many available Order Items and mak" +
                    "e a Reservation", ProgrammingLanguage.CSharp, ((string[])(null)));
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
#line 20
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "seat type",
                        "rate",
                        "quota"});
            table1.AddRow(new string[] {
                        "General admission",
                        "$199",
                        "2"});
            table1.AddRow(new string[] {
                        "CQRS Workshop",
                        "$500",
                        "2"});
            table1.AddRow(new string[] {
                        "Additional cocktail party",
                        "$50",
                        "2"});
#line 21
 testRunner.Given("the list of the available Order Items for the CQRS summit 2012 conference with th" +
                    "e slug code GroupRegE2Esad", ((string)(null)), table1);
#line hidden
        }
        
        public virtual void SetFixture(RegistrantWorkflowForRegisteringAGroupOfAttendeesForAConferenceSadPathFeature.FixtureData fixtureData)
        {
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Registrant workflow for registering a group of Attendees for a conference (sad pa" +
            "th)")]
        [Xunit.TraitAttribute("Description", "All the Order Items are available, then some get waitlisted and some reserved")]
        public virtual void AllTheOrderItemsAreAvailableThenSomeGetWaitlistedAndSomeReserved()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("All the Order Items are available, then some get waitlisted and some reserved", ((string[])(null)));
#line 30
this.ScenarioSetup(scenarioInfo);
#line 20
this.FeatureBackground();
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "seat type",
                        "quantity"});
            table2.AddRow(new string[] {
                        "General admission",
                        "2"});
            table2.AddRow(new string[] {
                        "Additional cocktail party",
                        "2"});
#line 31
 testRunner.Given("the selected Order Items", ((string)(null)), table2);
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "seat type",
                        "quantity"});
            table3.AddRow(new string[] {
                        "General admission",
                        "1"});
#line 35
 testRunner.And("these Seat Types becomes unavailable before the Registrant make the reservation", ((string)(null)), table3);
#line 38
 testRunner.When("the Registrant proceed to make the Reservation");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "seat type",
                        "quantity"});
            table4.AddRow(new string[] {
                        "General admission",
                        "1"});
#line 39
 testRunner.Then("the Registrant is offered to be waitlisted for these Order Items", ((string)(null)), table4);
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "seat type",
                        "quantity"});
            table5.AddRow(new string[] {
                        "General admission",
                        "1"});
            table5.AddRow(new string[] {
                        "Additional cocktail party",
                        "2"});
#line 42
 testRunner.And("these Order Items should be reserved", ((string)(null)), table5);
#line 46
 testRunner.And("the total should read $299");
#line 47
 testRunner.And("the countdown started");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(Skip="Ignored")]
        [Xunit.TraitAttribute("FeatureTitle", "Registrant workflow for registering a group of Attendees for a conference (sad pa" +
            "th)")]
        [Xunit.TraitAttribute("Description", "Allocate some purchased Seats for a group")]
        public virtual void AllocateSomePurchasedSeatsForAGroup()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Allocate some purchased Seats for a group", new string[] {
                        "Ignore"});
#line 52
this.ScenarioSetup(scenarioInfo);
#line 20
this.FeatureBackground();
#line 53
testRunner.Given("the ConfirmSuccessfulRegistration");
#line 54
testRunner.And("the order access code is 6789");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "First name",
                        "Last name",
                        "email address",
                        "Seat type"});
            table6.AddRow(new string[] {
                        "William",
                        "Weber",
                        "William@Weber.com",
                        "General admission"});
#line 55
testRunner.And("the Registrant assign the group purchased Seats to attendees as following", ((string)(null)), table6);
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "First name",
                        "Last name",
                        "email address",
                        "Seat type"});
            table7.AddRow(new string[] {
                        "Mani",
                        "Kris",
                        "Mani@Kris.com",
                        "Additional cocktail party"});
#line 58
testRunner.And("leave unassigned these individual purchased seats", ((string)(null)), table7);
#line 61
testRunner.Then("the Registrant should get a Seat Assignment confirmation");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "Access code",
                        "email address",
                        "Seat type"});
            table8.AddRow(new string[] {
                        "6789-1",
                        "William@Weber.com",
                        "General admission"});
#line 62
testRunner.And("the Attendees should get an email informing about the conference and the Seat Typ" +
                    "e with Seat Access Code", ((string)(null)), table8);
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.8.1.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                RegistrantWorkflowForRegisteringAGroupOfAttendeesForAConferenceSadPathFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                RegistrantWorkflowForRegisteringAGroupOfAttendeesForAConferenceSadPathFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
