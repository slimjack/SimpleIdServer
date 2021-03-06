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
namespace SimpleIdServer.Scim.Host.Acceptance.Tests.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class UsersErrorsFeature : Xunit.IClassFixture<UsersErrorsFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "UsersErrors.feature"
#line hidden
        
        public UsersErrorsFeature(UsersErrorsFeature.FixtureData fixtureData, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "UsersErrors", "\tCheck the errors returned by the /Users endpoint", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        
        [Xunit.FactAttribute(DisplayName="Error is returned when schemas attribute is missing (HTTP POST)")]
        [Xunit.TraitAttribute("FeatureTitle", "UsersErrors")]
        [Xunit.TraitAttribute("Description", "Error is returned when schemas attribute is missing (HTTP POST)")]
        public virtual void ErrorIsReturnedWhenSchemasAttributeIsMissingHTTPPOST()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Error is returned when schemas attribute is missing (HTTP POST)", null, ((string[])(null)));
#line 4
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table14 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
#line 5
 testRunner.When("execute HTTP POST JSON request \'http://localhost/Users\'", ((string)(null)), table14, "When ");
#line 8
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 10
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 11
 testRunner.Then("JSON \'status\'=\'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 12
 testRunner.Then("JSON \'response.schemas[0]\'=\'urn:ietf:params:scim:api:messages:2.0:Error\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 13
 testRunner.Then("JSON \'response.status\'=\'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 14
 testRunner.Then("JSON \'response.scimType\'=\'invalidSyntax\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 15
 testRunner.Then("JSON \'response.detail\'=\'Request is unparsable, syntactically incorrect, or violat" +
                    "es schema.\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Error is returned when schema is not valid (HTTP POST)")]
        [Xunit.TraitAttribute("FeatureTitle", "UsersErrors")]
        [Xunit.TraitAttribute("Description", "Error is returned when schema is not valid (HTTP POST)")]
        public virtual void ErrorIsReturnedWhenSchemaIsNotValidHTTPPOST()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Error is returned when schema is not valid (HTTP POST)", null, ((string[])(null)));
#line 17
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table15 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table15.AddRow(new string[] {
                        "schemas",
                        "[ \"invalidschema\" ]"});
#line 18
 testRunner.When("execute HTTP POST JSON request \'http://localhost/Users\'", ((string)(null)), table15, "When ");
#line 22
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 24
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 25
 testRunner.Then("JSON \'status\'=\'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 26
 testRunner.Then("JSON \'response.schemas[0]\'=\'urn:ietf:params:scim:api:messages:2.0:Error\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 27
 testRunner.Then("JSON \'response.status\'=\'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 28
 testRunner.Then("JSON \'response.scimType\'=\'invalidSyntax\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 29
 testRunner.Then("JSON \'response.detail\'=\'Request is unparsable, syntactically incorrect, or violat" +
                    "es schema.\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Error is returned when trying to add two resources with the same unique attribute" +
            "")]
        [Xunit.TraitAttribute("FeatureTitle", "UsersErrors")]
        [Xunit.TraitAttribute("Description", "Error is returned when trying to add two resources with the same unique attribute" +
            "")]
        public virtual void ErrorIsReturnedWhenTryingToAddTwoResourcesWithTheSameUniqueAttribute()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Error is returned when trying to add two resources with the same unique attribute" +
                    "", null, ((string[])(null)));
#line 31
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table16 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table16.AddRow(new string[] {
                        "schemas",
                        "[ \"urn:ietf:params:scim:schemas:core:2.0:User\" ]"});
            table16.AddRow(new string[] {
                        "userName",
                        "bjen"});
            table16.AddRow(new string[] {
                        "name",
                        "{ \"formatted\" : \"formatted\", \"familyName\": \"familyName\", \"givenName\": \"givenName\"" +
                            " }"});
#line 32
 testRunner.When("execute HTTP POST JSON request \'http://localhost/Users\'", ((string)(null)), table16, "When ");
#line hidden
            TechTalk.SpecFlow.Table table17 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table17.AddRow(new string[] {
                        "schemas",
                        "[ \"urn:ietf:params:scim:schemas:core:2.0:User\" ]"});
            table17.AddRow(new string[] {
                        "userName",
                        "bjen"});
            table17.AddRow(new string[] {
                        "name",
                        "{ \"formatted\" : \"formatted\", \"familyName\": \"familyName\", \"givenName\": \"givenName\"" +
                            " }"});
#line 39
 testRunner.When("execute HTTP POST JSON request \'http://localhost/Users\'", ((string)(null)), table17, "When ");
#line 45
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 47
 testRunner.Then("HTTP status code equals to \'409\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 48
 testRunner.Then("JSON \'status\'=\'409\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 49
 testRunner.Then("JSON \'response.schemas[0]\'=\'urn:ietf:params:scim:api:messages:2.0:Error\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 50
 testRunner.Then("JSON \'response.status\'=\'409\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 51
 testRunner.Then("JSON \'response.scimType\'=\'uniqueness\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 52
 testRunner.Then("JSON \'response.detail\'=\'One or more of the attribute values are already in use or" +
                    " are reserved.\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Error is returned when the user doesn\'t exist (HTTP GET)")]
        [Xunit.TraitAttribute("FeatureTitle", "UsersErrors")]
        [Xunit.TraitAttribute("Description", "Error is returned when the user doesn\'t exist (HTTP GET)")]
        public virtual void ErrorIsReturnedWhenTheUserDoesntExistHTTPGET()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Error is returned when the user doesn\'t exist (HTTP GET)", null, ((string[])(null)));
#line 54
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 55
 testRunner.When("execute HTTP GET request \'http://localhost/Users/1\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 57
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 59
 testRunner.Then("HTTP status code equals to \'404\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 60
 testRunner.Then("JSON \'status\'=\'404\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 61
 testRunner.Then("JSON \'response.schemas[0]\'=\'urn:ietf:params:scim:api:messages:2.0:Error\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 62
 testRunner.Then("JSON \'response.detail\'=\'Resource 1 not found.\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Error is returned when trying to remove an unknown user (HTTP DELETE)")]
        [Xunit.TraitAttribute("FeatureTitle", "UsersErrors")]
        [Xunit.TraitAttribute("Description", "Error is returned when trying to remove an unknown user (HTTP DELETE)")]
        public virtual void ErrorIsReturnedWhenTryingToRemoveAnUnknownUserHTTPDELETE()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Error is returned when trying to remove an unknown user (HTTP DELETE)", null, ((string[])(null)));
#line 64
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 65
 testRunner.When("execute HTTP DELETE request \'http://localhost/Users/1\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 67
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 69
 testRunner.Then("HTTP status code equals to \'404\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 70
 testRunner.Then("JSON \'status\'=\'404\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 71
 testRunner.Then("JSON \'response.schemas[0]\'=\'urn:ietf:params:scim:api:messages:2.0:Error\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 72
 testRunner.Then("JSON \'response.detail\'=\'Resource 1 not found.\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Error is returned when schemas attribute is missing (HTTP PUT)")]
        [Xunit.TraitAttribute("FeatureTitle", "UsersErrors")]
        [Xunit.TraitAttribute("Description", "Error is returned when schemas attribute is missing (HTTP PUT)")]
        public virtual void ErrorIsReturnedWhenSchemasAttributeIsMissingHTTPPUT()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Error is returned when schemas attribute is missing (HTTP PUT)", null, ((string[])(null)));
#line 74
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table18 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
#line 75
 testRunner.When("execute HTTP PUT JSON request \'http://localhost/Users/id\'", ((string)(null)), table18, "When ");
#line 78
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 80
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 81
 testRunner.Then("JSON \'status\'=\'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 82
 testRunner.Then("JSON \'response.schemas[0]\'=\'urn:ietf:params:scim:api:messages:2.0:Error\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 83
 testRunner.Then("JSON \'response.status\'=\'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 84
 testRunner.Then("JSON \'response.scimType\'=\'invalidSyntax\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 85
 testRunner.Then("JSON \'response.detail\'=\'Request is unparsable, syntactically incorrect, or violat" +
                    "es schema.\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Error is returned when schema is not valid (HTTP PUT)")]
        [Xunit.TraitAttribute("FeatureTitle", "UsersErrors")]
        [Xunit.TraitAttribute("Description", "Error is returned when schema is not valid (HTTP PUT)")]
        public virtual void ErrorIsReturnedWhenSchemaIsNotValidHTTPPUT()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Error is returned when schema is not valid (HTTP PUT)", null, ((string[])(null)));
#line 87
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table19 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table19.AddRow(new string[] {
                        "schemas",
                        "[ \"invalidschema\" ]"});
#line 88
 testRunner.When("execute HTTP PUT JSON request \'http://localhost/Users/id\'", ((string)(null)), table19, "When ");
#line 92
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 94
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 95
 testRunner.Then("JSON \'status\'=\'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 96
 testRunner.Then("JSON \'response.schemas[0]\'=\'urn:ietf:params:scim:api:messages:2.0:Error\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 97
 testRunner.Then("JSON \'response.status\'=\'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 98
 testRunner.Then("JSON \'response.scimType\'=\'invalidSyntax\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 99
 testRunner.Then("JSON \'response.detail\'=\'Request is unparsable, syntactically incorrect, or violat" +
                    "es schema.\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Error is returned when trying to update an unknown resource (HTTP PUT)")]
        [Xunit.TraitAttribute("FeatureTitle", "UsersErrors")]
        [Xunit.TraitAttribute("Description", "Error is returned when trying to update an unknown resource (HTTP PUT)")]
        public virtual void ErrorIsReturnedWhenTryingToUpdateAnUnknownResourceHTTPPUT()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Error is returned when trying to update an unknown resource (HTTP PUT)", null, ((string[])(null)));
#line 101
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table20 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table20.AddRow(new string[] {
                        "schemas",
                        "[ \"urn:ietf:params:scim:schemas:core:2.0:User\" ]"});
#line 102
 testRunner.When("execute HTTP PUT JSON request \'http://localhost/Users/id\'", ((string)(null)), table20, "When ");
#line 106
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 108
 testRunner.Then("HTTP status code equals to \'404\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 109
 testRunner.Then("JSON \'status\'=\'404\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 110
 testRunner.Then("JSON \'response.schemas[0]\'=\'urn:ietf:params:scim:api:messages:2.0:Error\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 111
 testRunner.Then("JSON \'response.status\'=\'404\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 112
 testRunner.Then("JSON \'response.scimType\'=\'notFound\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 113
 testRunner.Then("JSON \'response.detail\'=\'Resource does not exist\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Error is returned when update an immutable attribute (HTTP PUT)")]
        [Xunit.TraitAttribute("FeatureTitle", "UsersErrors")]
        [Xunit.TraitAttribute("Description", "Error is returned when update an immutable attribute (HTTP PUT)")]
        public virtual void ErrorIsReturnedWhenUpdateAnImmutableAttributeHTTPPUT()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Error is returned when update an immutable attribute (HTTP PUT)", null, ((string[])(null)));
#line 115
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table21 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table21.AddRow(new string[] {
                        "schemas",
                        "[ \"urn:ietf:params:scim:schemas:core:2.0:User\" ]"});
            table21.AddRow(new string[] {
                        "userName",
                        "bjen"});
            table21.AddRow(new string[] {
                        "name",
                        "{ \"formatted\" : \"formatted\", \"familyName\": \"familyName\", \"givenName\": \"givenName\"" +
                            " }"});
#line 116
 testRunner.When("execute HTTP POST JSON request \'http://localhost/Users\'", ((string)(null)), table21, "When ");
#line 122
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 123
 testRunner.And("extract \'id\' from JSON body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table22 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table22.AddRow(new string[] {
                        "schemas",
                        "[ \"urn:ietf:params:scim:schemas:core:2.0:User\" ]"});
            table22.AddRow(new string[] {
                        "immutable",
                        "str"});
#line 124
 testRunner.And("execute HTTP PUT JSON request \'http://localhost/Users/$id$\'", ((string)(null)), table22, "And ");
#line 129
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 131
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 132
 testRunner.Then("JSON \'status\'=\'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 133
 testRunner.Then("JSON \'response.schemas[0]\'=\'urn:ietf:params:scim:api:messages:2.0:Error\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 134
 testRunner.Then("JSON \'response.status\'=\'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 135
 testRunner.Then("JSON \'response.scimType\'=\'mutability\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Error is returned when schemas attribute is missing (HTTP PATCH)")]
        [Xunit.TraitAttribute("FeatureTitle", "UsersErrors")]
        [Xunit.TraitAttribute("Description", "Error is returned when schemas attribute is missing (HTTP PATCH)")]
        public virtual void ErrorIsReturnedWhenSchemasAttributeIsMissingHTTPPATCH()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Error is returned when schemas attribute is missing (HTTP PATCH)", null, ((string[])(null)));
#line 137
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table23 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
#line 138
 testRunner.When("execute HTTP PATCH JSON request \'http://localhost/Users/id\'", ((string)(null)), table23, "When ");
#line 141
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 143
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 144
 testRunner.Then("JSON \'status\'=\'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 145
 testRunner.Then("JSON \'response.schemas[0]\'=\'urn:ietf:params:scim:api:messages:2.0:Error\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 146
 testRunner.Then("JSON \'response.status\'=\'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 147
 testRunner.Then("JSON \'response.scimType\'=\'invalidSyntax\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 148
 testRunner.Then("JSON \'response.detail\'=\'Request is unparsable, syntactically incorrect, or violat" +
                    "es schema.\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Error is returned when schema is not valid (HTTP PATCH)")]
        [Xunit.TraitAttribute("FeatureTitle", "UsersErrors")]
        [Xunit.TraitAttribute("Description", "Error is returned when schema is not valid (HTTP PATCH)")]
        public virtual void ErrorIsReturnedWhenSchemaIsNotValidHTTPPATCH()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Error is returned when schema is not valid (HTTP PATCH)", null, ((string[])(null)));
#line 150
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table24 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table24.AddRow(new string[] {
                        "schemas",
                        "[ \"invalidschema\" ]"});
#line 151
 testRunner.When("execute HTTP PATCH JSON request \'http://localhost/Users/id\'", ((string)(null)), table24, "When ");
#line 155
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 157
 testRunner.Then("HTTP status code equals to \'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 158
 testRunner.Then("JSON \'status\'=\'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 159
 testRunner.Then("JSON \'response.schemas[0]\'=\'urn:ietf:params:scim:api:messages:2.0:Error\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 160
 testRunner.Then("JSON \'response.status\'=\'400\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 161
 testRunner.Then("JSON \'response.scimType\'=\'invalidSyntax\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 162
 testRunner.Then("JSON \'response.detail\'=\'Request is unparsable, syntactically incorrect, or violat" +
                    "es schema.\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute(DisplayName="Error is returned when trying to patch an unknown resource (HTTP PATCH)")]
        [Xunit.TraitAttribute("FeatureTitle", "UsersErrors")]
        [Xunit.TraitAttribute("Description", "Error is returned when trying to patch an unknown resource (HTTP PATCH)")]
        public virtual void ErrorIsReturnedWhenTryingToPatchAnUnknownResourceHTTPPATCH()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Error is returned when trying to patch an unknown resource (HTTP PATCH)", null, ((string[])(null)));
#line 164
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table25 = new TechTalk.SpecFlow.Table(new string[] {
                        "Key",
                        "Value"});
            table25.AddRow(new string[] {
                        "schemas",
                        "[ \"urn:ietf:params:scim:api:messages:2.0:PatchOp\" ]"});
            table25.AddRow(new string[] {
                        "Operations",
                        "[ ]"});
#line 165
 testRunner.When("execute HTTP PATCH JSON request \'http://localhost/Users/id\'", ((string)(null)), table25, "When ");
#line 170
 testRunner.And("extract JSON from body", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 172
 testRunner.Then("HTTP status code equals to \'404\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 173
 testRunner.Then("JSON \'status\'=\'404\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 174
 testRunner.Then("JSON \'response.schemas[0]\'=\'urn:ietf:params:scim:api:messages:2.0:Error\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 175
 testRunner.Then("JSON \'response.status\'=\'404\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 176
 testRunner.Then("JSON \'response.scimType\'=\'notFound\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 177
 testRunner.Then("JSON \'response.detail\'=\'Resource does not exist\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.0.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                UsersErrorsFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                UsersErrorsFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
