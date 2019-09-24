// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:3.0.0.0
//      SpecFlow Generator Version:3.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace SimpleIdServer.OAuth.Host.Acceptance.Tests.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class RegistrationErrorsFeature : Xunit.IClassFixture<RegistrationErrorsFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "RegistrationErrors.feature"
#line hidden
        
        public RegistrationErrorsFeature(RegistrationErrorsFeature.FixtureData fixtureData, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "RegistrationErrors", "\tCheck errors returned by client registration endpoint", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [Xunit.FactAttribute(DisplayName="Error is returned when grant_type is not supported")]
        [Xunit.TraitAttribute("FeatureTitle", "RegistrationErrors")]
        [Xunit.TraitAttribute("Description", "Error is returned when grant_type is not supported")]
        public virtual void ErrorIsReturnedWhenGrant_TypeIsNotSupported()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Error is returned when grant_type is not supported", null, ((string[])(null)));
#line 4
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table15 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table15.AddRow(new string[] {
                        "grant_types",
                        "[a,b]"});
#line 5
 testRunner.When("execute HTTP POST JSON request \'http://localhost/register\'", ((string)(null)), table15, "When ");
#line 9
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 11
 testRunner.Then("JSON \'error\'=\'invalid_client_metadata\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 12
 testRunner.Then("JSON \'error_description\'=\'grant types a,b are not supported\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Error is returned when token_endpoint_auth_method is not supported")]
        [Xunit.TraitAttribute("FeatureTitle", "RegistrationErrors")]
        [Xunit.TraitAttribute("Description", "Error is returned when token_endpoint_auth_method is not supported")]
        public virtual void ErrorIsReturnedWhenToken_Endpoint_Auth_MethodIsNotSupported()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Error is returned when token_endpoint_auth_method is not supported", null, ((string[])(null)));
#line 14
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table16 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table16.AddRow(new string[] {
                        "token_endpoint_auth_method",
                        "invalid"});
#line 15
 testRunner.When("execute HTTP POST JSON request \'http://localhost/register\'", ((string)(null)), table16, "When ");
#line 19
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 21
 testRunner.Then("JSON \'error\'=\'invalid_client_metadata\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 22
 testRunner.Then("JSON \'error_description\'=\'unknown authentication method : invalid\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Error is returned when response_types is not supported")]
        [Xunit.TraitAttribute("FeatureTitle", "RegistrationErrors")]
        [Xunit.TraitAttribute("Description", "Error is returned when response_types is not supported")]
        public virtual void ErrorIsReturnedWhenResponse_TypesIsNotSupported()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Error is returned when response_types is not supported", null, ((string[])(null)));
#line 24
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table17 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table17.AddRow(new string[] {
                        "response_types",
                        "[a,b]"});
#line 25
 testRunner.When("execute HTTP POST JSON request \'http://localhost/register\'", ((string)(null)), table17, "When ");
#line 29
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 31
 testRunner.Then("JSON \'error\'=\'invalid_client_metadata\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 32
 testRunner.Then("JSON \'error_description\'=\'response types a,b are not supported\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Error is returned when response_type is missing")]
        [Xunit.TraitAttribute("FeatureTitle", "RegistrationErrors")]
        [Xunit.TraitAttribute("Description", "Error is returned when response_type is missing")]
        public virtual void ErrorIsReturnedWhenResponse_TypeIsMissing()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Error is returned when response_type is missing", null, ((string[])(null)));
#line 34
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table18 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table18.AddRow(new string[] {
                        "response_types",
                        "[token]"});
            table18.AddRow(new string[] {
                        "grant_types",
                        "[implicit,authorization_code]"});
#line 35
 testRunner.When("execute HTTP POST JSON request \'http://localhost/register\'", ((string)(null)), table18, "When ");
#line 40
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 42
 testRunner.Then("JSON \'error\'=\'invalid_client_metadata\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 43
 testRunner.Then("JSON \'error_description\'=\'valid response type must be passed for the grant type a" +
                    "uthorization_code\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Error is returned when redirect_uris is missing")]
        [Xunit.TraitAttribute("FeatureTitle", "RegistrationErrors")]
        [Xunit.TraitAttribute("Description", "Error is returned when redirect_uris is missing")]
        public virtual void ErrorIsReturnedWhenRedirect_UrisIsMissing()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Error is returned when redirect_uris is missing", null, ((string[])(null)));
#line 45
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table19 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table19.AddRow(new string[] {
                        "response_types",
                        "[token]"});
            table19.AddRow(new string[] {
                        "grant_types",
                        "[implicit]"});
#line 46
 testRunner.When("execute HTTP POST JSON request \'http://localhost/register\'", ((string)(null)), table19, "When ");
#line 51
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 53
 testRunner.Then("JSON \'error\'=\'invalid_client_metadata\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 54
 testRunner.Then("JSON \'error_description\'=\'missing parameter redirect_uris\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Error is returned when redirect_uris is invalid")]
        [Xunit.TraitAttribute("FeatureTitle", "RegistrationErrors")]
        [Xunit.TraitAttribute("Description", "Error is returned when redirect_uris is invalid")]
        public virtual void ErrorIsReturnedWhenRedirect_UrisIsInvalid()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Error is returned when redirect_uris is invalid", null, ((string[])(null)));
#line 56
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table20 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table20.AddRow(new string[] {
                        "response_types",
                        "[token]"});
            table20.AddRow(new string[] {
                        "grant_types",
                        "[implicit]"});
            table20.AddRow(new string[] {
                        "redirect_uris",
                        "[invalid]"});
#line 57
 testRunner.When("execute HTTP POST JSON request \'http://localhost/register\'", ((string)(null)), table20, "When ");
#line 63
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 65
 testRunner.Then("JSON \'error\'=\'invalid_redirect_uri\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 66
 testRunner.Then("JSON \'error_description\'=\'redirect uri invalid is not correct\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Error is returned when scope is not supported")]
        [Xunit.TraitAttribute("FeatureTitle", "RegistrationErrors")]
        [Xunit.TraitAttribute("Description", "Error is returned when scope is not supported")]
        public virtual void ErrorIsReturnedWhenScopeIsNotSupported()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Error is returned when scope is not supported", null, ((string[])(null)));
#line 68
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table21 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table21.AddRow(new string[] {
                        "scope",
                        "a"});
            table21.AddRow(new string[] {
                        "redirect_uris",
                        "[http://localhost]"});
#line 69
 testRunner.When("execute HTTP POST JSON request \'http://localhost/register\'", ((string)(null)), table21, "When ");
#line 74
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 76
 testRunner.Then("JSON \'error\'=\'invalid_client_metadata\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 77
 testRunner.Then("JSON \'error_description\'=\'scopes a are not supported\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Error is returned when software_statement is not a JWS token")]
        [Xunit.TraitAttribute("FeatureTitle", "RegistrationErrors")]
        [Xunit.TraitAttribute("Description", "Error is returned when software_statement is not a JWS token")]
        public virtual void ErrorIsReturnedWhenSoftware_StatementIsNotAJWSToken()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Error is returned when software_statement is not a JWS token", null, ((string[])(null)));
#line 79
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table22 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table22.AddRow(new string[] {
                        "software_statement",
                        "a"});
#line 80
 testRunner.When("execute HTTP POST JSON request \'http://localhost/register\'", ((string)(null)), table22, "When ");
#line 84
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 86
 testRunner.Then("JSON \'error\'=\'invalid_software_statement\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 87
 testRunner.Then("JSON \'error_description\'=\'software statement is not a JWS token\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Error is returned when software_statement is a bad JWS token")]
        [Xunit.TraitAttribute("FeatureTitle", "RegistrationErrors")]
        [Xunit.TraitAttribute("Description", "Error is returned when software_statement is a bad JWS token")]
        public virtual void ErrorIsReturnedWhenSoftware_StatementIsABadJWSToken()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Error is returned when software_statement is a bad JWS token", null, ((string[])(null)));
#line 89
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table23 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table23.AddRow(new string[] {
                        "software_statement",
                        "a.b.c"});
#line 90
 testRunner.When("execute HTTP POST JSON request \'http://localhost/register\'", ((string)(null)), table23, "When ");
#line 94
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 96
 testRunner.Then("JSON \'error\'=\'invalid_software_statement\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 97
 testRunner.Then("JSON \'error_description\'=\'software statement is not a JWS token\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Error is returned when iss is not correct")]
        [Xunit.TraitAttribute("FeatureTitle", "RegistrationErrors")]
        [Xunit.TraitAttribute("Description", "Error is returned when iss is not correct")]
        public virtual void ErrorIsReturnedWhenIssIsNotCorrect()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Error is returned when iss is not correct", null, ((string[])(null)));
#line 99
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table24 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table24.AddRow(new string[] {
                        "iss",
                        "unknown"});
#line 100
 testRunner.When("build software statement", ((string)(null)), table24, "When ");
#line hidden
            TechTalk.SpecFlow.Table table25 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table25.AddRow(new string[] {
                        "software_statement",
                        "$softwareStatement$"});
#line 104
 testRunner.When("execute HTTP POST JSON request \'http://localhost/register\'", ((string)(null)), table25, "When ");
#line 108
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 110
 testRunner.Then("JSON \'error\'=\'invalid_software_statement\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 111
 testRunner.Then("JSON \'error_description\'=\'software statement issuer is not trusted\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.0.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                RegistrationErrorsFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                RegistrationErrorsFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion