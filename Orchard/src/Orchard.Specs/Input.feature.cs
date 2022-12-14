// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.42000
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Orchard.Specs
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Input Field")]
    public partial class InputFieldFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Input.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Input Field", "  In order to add an input to my types\r\n  As an administrator\r\n  I want to create" +
                    ", edit and publish input fields", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
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
        [NUnit.Framework.DescriptionAttribute("Creating and using Input fields")]
        public virtual void CreatingAndUsingInputFields()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Creating and using Input fields", ((string[])(null)));
#line 6
this.ScenarioSetup(scenarioInfo);
#line 9
    testRunner.Given("I have installed Orchard", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 10
        testRunner.And("I have installed \"Orchard.Fields\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 11
    testRunner.When("I go to \"Admin/ContentTypes\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 12
    testRunner.Then("I should see \"<a[^>]*>.*?Create new type</a>\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 13
    testRunner.When("I go to \"Admin/ContentTypes/Create\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table1.AddRow(new string[] {
                        "DisplayName",
                        "Event"});
            table1.AddRow(new string[] {
                        "Name",
                        "Event"});
#line 14
        testRunner.And("I fill in", ((string)(null)), table1, "And ");
#line 18
        testRunner.And("I hit \"Create\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 19
        testRunner.And("I go to \"Admin/ContentTypes/\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 20
    testRunner.Then("I should see \"Event\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 23
    testRunner.When("I go to \"Admin/ContentTypes/Edit/Event\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 24
        testRunner.And("I follow \"Add Field\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table2.AddRow(new string[] {
                        "DisplayName",
                        "Contact"});
            table2.AddRow(new string[] {
                        "Name",
                        "Contact"});
            table2.AddRow(new string[] {
                        "FieldTypeName",
                        "InputField"});
#line 25
        testRunner.And("I fill in", ((string)(null)), table2, "And ");
#line 30
        testRunner.And("I hit \"Save\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 31
        testRunner.And("I am redirected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 32
    testRunner.Then("I should see \"The \\\"Contact\\\" field has been added.\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 35
    testRunner.When("I go to \"Admin/ContentTypes/Edit/Event\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table3.AddRow(new string[] {
                        "Fields[0].InputFieldSettings.Hint",
                        "Enter the contact email address"});
#line 36
        testRunner.And("I fill in", ((string)(null)), table3, "And ");
#line 39
        testRunner.And("I hit \"Save\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 40
        testRunner.And("I go to \"Admin/Contents/Create/Event\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 41
    testRunner.Then("I should see \"Enter the contact email address\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 53
    testRunner.When("I go to \"Admin/ContentTypes/Edit/Event\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table4.AddRow(new string[] {
                        "Fields[0].InputFieldSettings.Type",
                        "Email"});
#line 54
        testRunner.And("I fill in", ((string)(null)), table4, "And ");
#line 57
        testRunner.And("I hit \"Save\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 58
        testRunner.And("I go to \"Admin/Contents/Create/Event\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 59
    testRunner.Then("I should see \"type=\\\"email\\\"\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 62
    testRunner.When("I go to \"Admin/ContentTypes/Edit/Event\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table5.AddRow(new string[] {
                        "Fields[0].InputFieldSettings.Title",
                        "Enter an email address"});
#line 63
        testRunner.And("I fill in", ((string)(null)), table5, "And ");
#line 66
        testRunner.And("I hit \"Save\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 67
        testRunner.And("I go to \"Admin/Contents/Create/Event\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 68
    testRunner.Then("I should see \"title=\\\"Enter an email address\\\"\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 71
    testRunner.When("I go to \"Admin/ContentTypes/Edit/Event\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table6.AddRow(new string[] {
                        "Fields[0].InputFieldSettings.AutoFocus",
                        "true"});
#line 72
        testRunner.And("I fill in", ((string)(null)), table6, "And ");
#line 75
        testRunner.And("I hit \"Save\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 76
        testRunner.And("I go to \"Admin/Contents/Create/Event\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 77
    testRunner.Then("I should see \"autofocus=\\\"autofocus\\\"\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 80
    testRunner.When("I go to \"Admin/ContentTypes/Edit/Event\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table7.AddRow(new string[] {
                        "Fields[0].InputFieldSettings.AutoComplete",
                        "true"});
#line 81
        testRunner.And("I fill in", ((string)(null)), table7, "And ");
#line 84
        testRunner.And("I hit \"Save\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 85
        testRunner.And("I go to \"Admin/Contents/Create/Event\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 86
    testRunner.Then("I should see \"autocomplete=\\\"on\\\"\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 89
    testRunner.When("I go to \"Admin/ContentTypes/Edit/Event\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table8.AddRow(new string[] {
                        "Fields[0].InputFieldSettings.Placeholder",
                        "email@domain.com"});
#line 90
        testRunner.And("I fill in", ((string)(null)), table8, "And ");
#line 93
        testRunner.And("I hit \"Save\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 94
        testRunner.And("I go to \"Admin/Contents/Create/Event\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 95
    testRunner.Then("I should see \"placeholder=\\\"email@domain.com\\\"\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 98
    testRunner.When("I go to \"Admin/ContentTypes/Edit/Event\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table9.AddRow(new string[] {
                        "Fields[0].InputFieldSettings.MaxLength",
                        "100"});
#line 99
        testRunner.And("I fill in", ((string)(null)), table9, "And ");
#line 102
        testRunner.And("I hit \"Save\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 103
        testRunner.And("I go to \"Admin/Contents/Create/Event\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 104
    testRunner.Then("I should see \"maxlength=\\\"100\\\"\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 107
    testRunner.When("I go to \"Admin/ContentTypes/Edit/Event\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table10.AddRow(new string[] {
                        "Fields[0].InputFieldSettings.Required",
                        "true"});
#line 108
        testRunner.And("I fill in", ((string)(null)), table10, "And ");
#line 111
        testRunner.And("I hit \"Save\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 112
        testRunner.And("I go to \"Admin/Contents/Create/Event\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table11.AddRow(new string[] {
                        "Event.Contact.Value",
                        ""});
#line 113
        testRunner.And("I fill in", ((string)(null)), table11, "And ");
#line 116
        testRunner.And("I hit \"Save\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 117
    testRunner.Then("I should see \"The field Contact is mandatory.\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 120
    testRunner.When("I go to \"Admin/Contents/Create/Event\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 121
    testRunner.Then("I should see \"Contact\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table12.AddRow(new string[] {
                        "Event.Contact.Value",
                        "contact@orchardproject.net"});
#line 122
    testRunner.When("I fill in", ((string)(null)), table12, "When ");
#line 125
        testRunner.And("I hit \"Save\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 126
        testRunner.And("I am redirected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 127
    testRunner.Then("I should see \"Your Event has been created.\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 128
    testRunner.When("I go to \"Admin/Contents/List\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 129
    testRunner.Then("I should see \"Contact:\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 130
        testRunner.And("I should see \"contact@orchardproject.net\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 133
    testRunner.When("I go to \"Admin/ContentTypes/Edit/Event\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table13.AddRow(new string[] {
                        "Fields[0].InputFieldSettings.DefaultValue",
                        "contact@orchardproject.net"});
#line 134
        testRunner.And("I fill in", ((string)(null)), table13, "And ");
#line 137
        testRunner.And("I hit \"Save\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 138
        testRunner.And("I go to \"Admin/Contents/Create/Event\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 139
    testRunner.Then("I should see \"value=\\\"contact@orchardproject.net\\\"\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 142
    testRunner.When("I go to \"Admin/ContentTypes/Edit/Event\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table14 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table14.AddRow(new string[] {
                        "Fields[0].InputFieldSettings.Required",
                        "true"});
#line 143
        testRunner.And("I fill in", ((string)(null)), table14, "And ");
#line 146
        testRunner.And("I hit \"Save\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 147
        testRunner.And("I go to \"Admin/Contents/Create/Event\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 148
    testRunner.Then("I should see \"required=\\\"required\\\"\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 151
    testRunner.When("I go to \"Admin/ContentTypes/Edit/Event\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table15 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table15.AddRow(new string[] {
                        "Fields[0].InputFieldSettings.Required",
                        "false"});
#line 152
        testRunner.And("I fill in", ((string)(null)), table15, "And ");
#line 155
        testRunner.And("I hit \"Save\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 156
        testRunner.And("I go to \"Admin/Contents/Create/Event\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 157
    testRunner.Then("I should not see \"required=\\\"required\\\"\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
