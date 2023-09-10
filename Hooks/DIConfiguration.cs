using Boa.Constrictor.Screenplay;
using Boa.Constrictor.Selenium;
using OpenQA.Selenium.Chrome;

namespace tests.Hooks
{
    [Binding]
    public class DIConfiguration
    {
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
    }
}