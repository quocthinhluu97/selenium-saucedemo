using Boa.Constrictor.Screenplay;
using Boa.Constrictor.Selenium;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow.Infrastructure;

namespace tests.Hooks
{
    [Binding]
    public class DIConfiguration
    {
        private static ISpecFlowOutputHelper _outputHelper;
        private static readonly string currentDirectory = Directory.GetCurrentDirectory();

        [BeforeFeature(Order = 0)]
        public static void RegisterDI(FeatureContext featureContext)
        {
            var actor = new Actor("chrome", new ConsoleLogger());
            actor.Can(BrowseTheWeb.With(new ChromeDriver()));
            featureContext.FeatureContainer.RegisterInstanceAs(actor);
        }

        [AfterFeature]
        public static void CleanUp(FeatureContext featureContext)
        {
            var actor = featureContext.FeatureContainer.Resolve<Actor>();
            actor.AttemptsTo(QuitWebDriver.ForBrowser());
        }
        
        [AfterScenario]
        public static void HandleFailure(ScenarioContext scenarioContext, FeatureContext featureContext, ISpecFlowOutputHelper outputHelper)
        {
            var actor = featureContext.FeatureContainer.Resolve<Actor>();
            _outputHelper = outputHelper;
            if (scenarioContext.ScenarioExecutionStatus != ScenarioExecutionStatus.OK)
            {
                string screenShotPath = currentDirectory + "/../../../screenshots/";
                string screenShotFile = scenarioContext.ScenarioInfo.Title + "_failure.png";
                Console.WriteLine(screenShotPath);
                Console.WriteLine(screenShotFile);
                actor.AskingFor(CurrentScreenshot.SavedTo(screenShotPath, screenShotFile));
                _outputHelper.AddAttachment(screenShotPath + screenShotFile);
            }
        }
    }
}