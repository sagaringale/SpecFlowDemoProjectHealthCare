using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowLinkGroupDemo.Steps
{
    [Binding]
    public class Hooks
    {
        private static ExtentTest featureName;
        private static ExtentTest scenario;
        private static ExtentReports extent;
        public static string ReportPath;
        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            //    LinkGroupSteps.driver.Initialize();
            //    Page.Initialize();
            string path1 = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug", "");
            string path = path1 + "Reports\\index.html";
            ExtentHtmlReporter htmlReporter = new ExtentHtmlReporter(path);
            htmlReporter.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Standard;
            extent = new ExtentReports();
            extent.AttachReporter(htmlReporter);
        }
        [BeforeFeature]
        public static void BeforeFeature(FeatureContext featureContext)
        {
            //Create dynamic feature name
            featureName = extent.CreateTest<Feature>(featureContext.FeatureInfo.Title);
            Console.WriteLine("BeforeFeature");
        }
        [BeforeScenario]
        public void BeforeScenario(ScenarioContext scenarioContext)
        {

            Console.WriteLine("BeforeScenario");
            scenario = featureName.CreateNode<Scenario>(scenarioContext.ScenarioInfo.Title);
        }
        [AfterStep]
        public void InsertReportingSteps(ScenarioContext scenarioContext)
        {
            var stepType = scenarioContext.StepContext.StepInfo.StepDefinitionType.ToString();
            Console.WriteLine(stepType);
            if (scenarioContext.TestError == null)
            {
                if (stepType == "Given")
                    scenario.CreateNode<Given>(scenarioContext.StepContext.StepInfo.Text);
                else if (stepType == "When")
                    scenario.CreateNode<When>(scenarioContext.StepContext.StepInfo.Text);
                else if (stepType == "Then")
                    scenario.CreateNode<Then>(scenarioContext.StepContext.StepInfo.Text);
                else if (stepType == "And")
                    scenario.CreateNode<And>(scenarioContext.StepContext.StepInfo.Text);
            }
            else if (scenarioContext.TestError!= null)
            {
                if (stepType == "Given")
                {
                    scenario.CreateNode<Given>(scenarioContext.StepContext.StepInfo.Text).Fail(scenarioContext.TestError.StackTrace);
                }
                else if (stepType == "When")
                {
                    scenario.CreateNode<When>(scenarioContext.StepContext.StepInfo.Text).Fail(scenarioContext.TestError.StackTrace);
                }
                else if (stepType == "Then")
                {
                    scenario.CreateNode<Then>(scenarioContext.StepContext.StepInfo.Text).Fail(scenarioContext.TestError.StackTrace);
                }
                else if (stepType == "And")
                {
                    scenario.CreateNode<And>(scenarioContext.StepContext.StepInfo.Text).Fail(scenarioContext.TestError.StackTrace);
                }
            }
        }
        [AfterScenario]
        public void AfterScenario()
        {
            Console.WriteLine("AfterScenario");

            //implement logic that has to run after executing each scenario
            LinkGroupSteps.driver.Quit();
        }
        [AfterTestRun]
        public static void AfterTestRun()
        {
            //LinkGroupSteps.driver.Close();
            LinkGroupSteps.driver.Dispose();
            //kill the browser
            //Flush report once test completes
            extent.Flush();
            //kill the browser
        }
    }
}