using System;
using Boa.Constrictor.Screenplay;
using Boa.Constrictor.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace tests.Hooks
{
    [Binding]
    public class DIConfiguration
    {
        private readonly ScenarioContext _scenarioContext;

        public DIConfiguration(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [BeforeScenario(Order = 0)]
        public void RegisterDI()
        {
            var actor = new Actor("chrome", new ConsoleLogger());
            actor.Can(BrowseTheWeb.With(new ChromeDriver()));
            _scenarioContext.ScenarioContainer.RegisterInstanceAs(actor);
        }

        [AfterScenario]
        public void CleanUp()
        {
            var actor = _scenarioContext.ScenarioContainer.Resolve<Actor>();
            actor.AttemptsTo(QuitWebDriver.ForBrowser());
        }
    }
}