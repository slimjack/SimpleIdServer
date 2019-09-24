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
namespace SimpleIdServer.OpenID.Host.Acceptance.Tests.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class RegisterErrorsFeature : Xunit.IClassFixture<RegisterErrorsFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "RegisterErrors.feature"
#line hidden
        
        public RegisterErrorsFeature(RegisterErrorsFeature.FixtureData fixtureData, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "RegisterErrors", "\tCheck errors returned by client registration endpoint", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        
        [Xunit.FactAttribute(DisplayName="Error is returned when application_type is incorrect")]
        [Xunit.TraitAttribute("FeatureTitle", "RegisterErrors")]
        [Xunit.TraitAttribute("Description", "Error is returned when application_type is incorrect")]
        public virtual void ErrorIsReturnedWhenApplication_TypeIsIncorrect()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Error is returned when application_type is incorrect", null, ((string[])(null)));
#line 4
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table171 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table171.AddRow(new string[] {
                        "application_type",
                        "unknown"});
#line 5
 testRunner.When("execute HTTP POST JSON request \'http://localhost/register\'", ((string)(null)), table171, "When ");
#line 9
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 11
 testRunner.Then("JSON \'error\'=\'invalid_client_metadata\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 12
 testRunner.Then("JSON \'error_description\'=\'application type is invalid\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Error is returned when sectore_identifier_uri is incorrect")]
        [Xunit.TraitAttribute("FeatureTitle", "RegisterErrors")]
        [Xunit.TraitAttribute("Description", "Error is returned when sectore_identifier_uri is incorrect")]
        public virtual void ErrorIsReturnedWhenSectore_Identifier_UriIsIncorrect()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Error is returned when sectore_identifier_uri is incorrect", null, ((string[])(null)));
#line 14
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table172 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table172.AddRow(new string[] {
                        "sector_identifier_uri",
                        "unknown"});
#line 15
 testRunner.When("execute HTTP POST JSON request \'http://localhost/register\'", ((string)(null)), table172, "When ");
#line 19
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 21
 testRunner.Then("JSON \'error\'=\'invalid_client_metadata\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 22
 testRunner.Then("JSON \'error_description\'=\'sector_identifier_uri is not a valid URI\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Error is returned when sectore_identifier_uri doesn\'t contains HTTPS scheme")]
        [Xunit.TraitAttribute("FeatureTitle", "RegisterErrors")]
        [Xunit.TraitAttribute("Description", "Error is returned when sectore_identifier_uri doesn\'t contains HTTPS scheme")]
        public virtual void ErrorIsReturnedWhenSectore_Identifier_UriDoesntContainsHTTPSScheme()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Error is returned when sectore_identifier_uri doesn\'t contains HTTPS scheme", null, ((string[])(null)));
#line 24
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table173 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table173.AddRow(new string[] {
                        "sector_identifier_uri",
                        "http://localhost"});
#line 25
 testRunner.When("execute HTTP POST JSON request \'http://localhost/register\'", ((string)(null)), table173, "When ");
#line 29
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 31
 testRunner.Then("JSON \'error\'=\'invalid_client_metadata\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 32
 testRunner.Then("JSON \'error_description\'=\'sector_identifier_uri doesn\'t contain https scheme\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Error is returned when subject_type is not supported")]
        [Xunit.TraitAttribute("FeatureTitle", "RegisterErrors")]
        [Xunit.TraitAttribute("Description", "Error is returned when subject_type is not supported")]
        public virtual void ErrorIsReturnedWhenSubject_TypeIsNotSupported()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Error is returned when subject_type is not supported", null, ((string[])(null)));
#line 34
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table174 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table174.AddRow(new string[] {
                        "subject_type",
                        "unknown"});
#line 35
 testRunner.When("execute HTTP POST JSON request \'http://localhost/register\'", ((string)(null)), table174, "When ");
#line 39
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 41
 testRunner.Then("JSON \'error\'=\'invalid_client_metadata\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 42
 testRunner.Then("JSON \'error_description\'=\'subject_type is invalid\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Error is returned when id_token_signed_response_alg is not supported")]
        [Xunit.TraitAttribute("FeatureTitle", "RegisterErrors")]
        [Xunit.TraitAttribute("Description", "Error is returned when id_token_signed_response_alg is not supported")]
        public virtual void ErrorIsReturnedWhenId_Token_Signed_Response_AlgIsNotSupported()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Error is returned when id_token_signed_response_alg is not supported", null, ((string[])(null)));
#line 44
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table175 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table175.AddRow(new string[] {
                        "id_token_signed_response_alg",
                        "unknown"});
#line 45
 testRunner.When("execute HTTP POST JSON request \'http://localhost/register\'", ((string)(null)), table175, "When ");
#line 49
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 51
 testRunner.Then("JSON \'error\'=\'invalid_client_metadata\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 52
 testRunner.Then("JSON \'error_description\'=\'id_token_signed_response_alg is not supported\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Error is returned when id_token_encrypted_response_alg is not supported")]
        [Xunit.TraitAttribute("FeatureTitle", "RegisterErrors")]
        [Xunit.TraitAttribute("Description", "Error is returned when id_token_encrypted_response_alg is not supported")]
        public virtual void ErrorIsReturnedWhenId_Token_Encrypted_Response_AlgIsNotSupported()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Error is returned when id_token_encrypted_response_alg is not supported", null, ((string[])(null)));
#line 54
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table176 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table176.AddRow(new string[] {
                        "id_token_encrypted_response_alg",
                        "unknown"});
#line 55
 testRunner.When("execute HTTP POST JSON request \'http://localhost/register\'", ((string)(null)), table176, "When ");
#line 59
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 61
 testRunner.Then("JSON \'error\'=\'invalid_client_metadata\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 62
 testRunner.Then("JSON \'error_description\'=\'id_token_encrypted_response_alg is not supported\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Error is returned when id_token_encrypted_response_enc is not supported")]
        [Xunit.TraitAttribute("FeatureTitle", "RegisterErrors")]
        [Xunit.TraitAttribute("Description", "Error is returned when id_token_encrypted_response_enc is not supported")]
        public virtual void ErrorIsReturnedWhenId_Token_Encrypted_Response_EncIsNotSupported()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Error is returned when id_token_encrypted_response_enc is not supported", null, ((string[])(null)));
#line 64
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table177 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table177.AddRow(new string[] {
                        "id_token_encrypted_response_enc",
                        "unknown"});
#line 65
 testRunner.When("execute HTTP POST JSON request \'http://localhost/register\'", ((string)(null)), table177, "When ");
#line 69
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 71
 testRunner.Then("JSON \'error\'=\'invalid_client_metadata\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 72
 testRunner.Then("JSON \'error_description\'=\'id_token_encrypted_response_enc is not supported\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Error is returned when id_token_encrypted_response_enc is passed but not id_token" +
            "_signed_response_alg")]
        [Xunit.TraitAttribute("FeatureTitle", "RegisterErrors")]
        [Xunit.TraitAttribute("Description", "Error is returned when id_token_encrypted_response_enc is passed but not id_token" +
            "_signed_response_alg")]
        public virtual void ErrorIsReturnedWhenId_Token_Encrypted_Response_EncIsPassedButNotId_Token_Signed_Response_Alg()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Error is returned when id_token_encrypted_response_enc is passed but not id_token" +
                    "_signed_response_alg", null, ((string[])(null)));
#line 74
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table178 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table178.AddRow(new string[] {
                        "id_token_encrypted_response_enc",
                        "A128CBC-HS256"});
#line 75
 testRunner.When("execute HTTP POST JSON request \'http://localhost/register\'", ((string)(null)), table178, "When ");
#line 79
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 81
 testRunner.Then("JSON \'error\'=\'invalid_client_metadata\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 82
 testRunner.Then("JSON \'error_description\'=\'missing parameter id_token_encrypted_response_alg\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Error is returned when userinfo_signed_response_alg is not supported")]
        [Xunit.TraitAttribute("FeatureTitle", "RegisterErrors")]
        [Xunit.TraitAttribute("Description", "Error is returned when userinfo_signed_response_alg is not supported")]
        public virtual void ErrorIsReturnedWhenUserinfo_Signed_Response_AlgIsNotSupported()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Error is returned when userinfo_signed_response_alg is not supported", null, ((string[])(null)));
#line 84
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table179 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table179.AddRow(new string[] {
                        "userinfo_signed_response_alg",
                        "unknown"});
#line 85
 testRunner.When("execute HTTP POST JSON request \'http://localhost/register\'", ((string)(null)), table179, "When ");
#line 89
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 91
 testRunner.Then("JSON \'error\'=\'invalid_client_metadata\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 92
 testRunner.Then("JSON \'error_description\'=\'userinfo_signed_response_alg is not supported\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Error is returned when userinfo_encrypted_response_alg is not supported")]
        [Xunit.TraitAttribute("FeatureTitle", "RegisterErrors")]
        [Xunit.TraitAttribute("Description", "Error is returned when userinfo_encrypted_response_alg is not supported")]
        public virtual void ErrorIsReturnedWhenUserinfo_Encrypted_Response_AlgIsNotSupported()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Error is returned when userinfo_encrypted_response_alg is not supported", null, ((string[])(null)));
#line 94
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table180 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table180.AddRow(new string[] {
                        "userinfo_encrypted_response_alg",
                        "unknown"});
#line 95
 testRunner.When("execute HTTP POST JSON request \'http://localhost/register\'", ((string)(null)), table180, "When ");
#line 99
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 101
 testRunner.Then("JSON \'error\'=\'invalid_client_metadata\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 102
 testRunner.Then("JSON \'error_description\'=\'userinfo_encrypted_response_alg is not supported\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Error is returned when userinfo_encrypted_response_enc is not supported")]
        [Xunit.TraitAttribute("FeatureTitle", "RegisterErrors")]
        [Xunit.TraitAttribute("Description", "Error is returned when userinfo_encrypted_response_enc is not supported")]
        public virtual void ErrorIsReturnedWhenUserinfo_Encrypted_Response_EncIsNotSupported()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Error is returned when userinfo_encrypted_response_enc is not supported", null, ((string[])(null)));
#line 104
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table181 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table181.AddRow(new string[] {
                        "userinfo_encrypted_response_enc",
                        "unknown"});
#line 105
 testRunner.When("execute HTTP POST JSON request \'http://localhost/register\'", ((string)(null)), table181, "When ");
#line 109
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 111
 testRunner.Then("JSON \'error\'=\'invalid_client_metadata\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 112
 testRunner.Then("JSON \'error_description\'=\'userinfo_encrypted_response_enc is not supported\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Error is returned when userinfo_signed_response_enc is passed but not userinfo_en" +
            "crypted_response_alg")]
        [Xunit.TraitAttribute("FeatureTitle", "RegisterErrors")]
        [Xunit.TraitAttribute("Description", "Error is returned when userinfo_signed_response_enc is passed but not userinfo_en" +
            "crypted_response_alg")]
        public virtual void ErrorIsReturnedWhenUserinfo_Signed_Response_EncIsPassedButNotUserinfo_Encrypted_Response_Alg()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Error is returned when userinfo_signed_response_enc is passed but not userinfo_en" +
                    "crypted_response_alg", null, ((string[])(null)));
#line 114
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table182 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table182.AddRow(new string[] {
                        "userinfo_encrypted_response_enc",
                        "A128CBC-HS256"});
#line 115
 testRunner.When("execute HTTP POST JSON request \'http://localhost/register\'", ((string)(null)), table182, "When ");
#line 119
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 121
 testRunner.Then("JSON \'error\'=\'invalid_client_metadata\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 122
 testRunner.Then("JSON \'error_description\'=\'missing parameter userinfo_encrypted_response_alg\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Error is returned when request_object_signing_alg is not supported")]
        [Xunit.TraitAttribute("FeatureTitle", "RegisterErrors")]
        [Xunit.TraitAttribute("Description", "Error is returned when request_object_signing_alg is not supported")]
        public virtual void ErrorIsReturnedWhenRequest_Object_Signing_AlgIsNotSupported()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Error is returned when request_object_signing_alg is not supported", null, ((string[])(null)));
#line 124
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table183 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table183.AddRow(new string[] {
                        "request_object_signing_alg",
                        "unknown"});
#line 125
 testRunner.When("execute HTTP POST JSON request \'http://localhost/register\'", ((string)(null)), table183, "When ");
#line 129
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 131
 testRunner.Then("JSON \'error\'=\'invalid_client_metadata\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 132
 testRunner.Then("JSON \'error_description\'=\'request_object_signing_alg is not supported\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Error is returned when request_object_encryption_alg is not supported")]
        [Xunit.TraitAttribute("FeatureTitle", "RegisterErrors")]
        [Xunit.TraitAttribute("Description", "Error is returned when request_object_encryption_alg is not supported")]
        public virtual void ErrorIsReturnedWhenRequest_Object_Encryption_AlgIsNotSupported()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Error is returned when request_object_encryption_alg is not supported", null, ((string[])(null)));
#line 134
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table184 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table184.AddRow(new string[] {
                        "request_object_encryption_alg",
                        "unknown"});
#line 135
 testRunner.When("execute HTTP POST JSON request \'http://localhost/register\'", ((string)(null)), table184, "When ");
#line 139
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 141
 testRunner.Then("JSON \'error\'=\'invalid_client_metadata\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 142
 testRunner.Then("JSON \'error_description\'=\'request_object_encryption_alg is not supported\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Error is returned when request_object_encryption_enc is not supported")]
        [Xunit.TraitAttribute("FeatureTitle", "RegisterErrors")]
        [Xunit.TraitAttribute("Description", "Error is returned when request_object_encryption_enc is not supported")]
        public virtual void ErrorIsReturnedWhenRequest_Object_Encryption_EncIsNotSupported()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Error is returned when request_object_encryption_enc is not supported", null, ((string[])(null)));
#line 144
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table185 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table185.AddRow(new string[] {
                        "request_object_encryption_enc",
                        "unknown"});
#line 145
 testRunner.When("execute HTTP POST JSON request \'http://localhost/register\'", ((string)(null)), table185, "When ");
#line 149
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 151
 testRunner.Then("JSON \'error\'=\'invalid_client_metadata\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 152
 testRunner.Then("JSON \'error_description\'=\'request_object_encryption_enc is not supported\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Error is returned when request_object_encryption_enc is passed but not request_ob" +
            "ject_encryption_alg")]
        [Xunit.TraitAttribute("FeatureTitle", "RegisterErrors")]
        [Xunit.TraitAttribute("Description", "Error is returned when request_object_encryption_enc is passed but not request_ob" +
            "ject_encryption_alg")]
        public virtual void ErrorIsReturnedWhenRequest_Object_Encryption_EncIsPassedButNotRequest_Object_Encryption_Alg()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Error is returned when request_object_encryption_enc is passed but not request_ob" +
                    "ject_encryption_alg", null, ((string[])(null)));
#line 154
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table186 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table186.AddRow(new string[] {
                        "request_object_encryption_enc",
                        "A128CBC-HS256"});
#line 155
 testRunner.When("execute HTTP POST JSON request \'http://localhost/register\'", ((string)(null)), table186, "When ");
#line 159
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 161
 testRunner.Then("JSON \'error\'=\'invalid_client_metadata\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 162
 testRunner.Then("JSON \'error_description\'=\'missing parameter request_object_encryption_alg\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Error is returned when a web client has invalid redirect_uri")]
        [Xunit.TraitAttribute("FeatureTitle", "RegisterErrors")]
        [Xunit.TraitAttribute("Description", "Error is returned when a web client has invalid redirect_uri")]
        public virtual void ErrorIsReturnedWhenAWebClientHasInvalidRedirect_Uri()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Error is returned when a web client has invalid redirect_uri", null, ((string[])(null)));
#line 164
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table187 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table187.AddRow(new string[] {
                        "redirect_uris",
                        "[invalid]"});
            table187.AddRow(new string[] {
                        "application_type",
                        "web"});
#line 165
 testRunner.When("execute HTTP POST JSON request \'http://localhost/register\'", ((string)(null)), table187, "When ");
#line 170
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 172
 testRunner.Then("JSON \'error\'=\'invalid_redirect_uri\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 173
 testRunner.Then("JSON \'error_description\'=\'redirect uri invalid is not correct\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Error is returned when a native client has invalid redirect_uri")]
        [Xunit.TraitAttribute("FeatureTitle", "RegisterErrors")]
        [Xunit.TraitAttribute("Description", "Error is returned when a native client has invalid redirect_uri")]
        public virtual void ErrorIsReturnedWhenANativeClientHasInvalidRedirect_Uri()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Error is returned when a native client has invalid redirect_uri", null, ((string[])(null)));
#line 175
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table188 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table188.AddRow(new string[] {
                        "redirect_uris",
                        "[invalid]"});
            table188.AddRow(new string[] {
                        "application_type",
                        "native"});
#line 176
 testRunner.When("execute HTTP POST JSON request \'http://localhost/register\'", ((string)(null)), table188, "When ");
#line 181
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 183
 testRunner.Then("JSON \'error\'=\'invalid_redirect_uri\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 184
 testRunner.Then("JSON \'error_description\'=\'redirect uri invalid is not correct\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Error is returned when a web client has redirect_uri without https scheme")]
        [Xunit.TraitAttribute("FeatureTitle", "RegisterErrors")]
        [Xunit.TraitAttribute("Description", "Error is returned when a web client has redirect_uri without https scheme")]
        public virtual void ErrorIsReturnedWhenAWebClientHasRedirect_UriWithoutHttpsScheme()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Error is returned when a web client has redirect_uri without https scheme", null, ((string[])(null)));
#line 186
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table189 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table189.AddRow(new string[] {
                        "redirect_uris",
                        "[http://localhost]"});
#line 187
 testRunner.When("execute HTTP POST JSON request \'http://localhost/register\'", ((string)(null)), table189, "When ");
#line 191
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 193
 testRunner.Then("JSON \'error\'=\'invalid_redirect_uri\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 194
 testRunner.Then("JSON \'error_description\'=\'redirect_uri does not contain https scheme\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Error is returned when a web client has redirect_uri with localhost")]
        [Xunit.TraitAttribute("FeatureTitle", "RegisterErrors")]
        [Xunit.TraitAttribute("Description", "Error is returned when a web client has redirect_uri with localhost")]
        public virtual void ErrorIsReturnedWhenAWebClientHasRedirect_UriWithLocalhost()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Error is returned when a web client has redirect_uri with localhost", null, ((string[])(null)));
#line 196
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table190 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table190.AddRow(new string[] {
                        "redirect_uris",
                        "[https://localhost]"});
#line 197
 testRunner.When("execute HTTP POST JSON request \'http://localhost/register\'", ((string)(null)), table190, "When ");
#line 201
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 203
 testRunner.Then("JSON \'error\'=\'invalid_redirect_uri\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 204
 testRunner.Then("JSON \'error_description\'=\'redirect_uri must not contain localhost\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.0.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                RegisterErrorsFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                RegisterErrorsFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion