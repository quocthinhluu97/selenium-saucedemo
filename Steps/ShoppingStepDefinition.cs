using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Boa.Constrictor.Screenplay;
using Boa.Constrictor.Selenium;
using FluentAssertions;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using tests.Interactions;
using tests.Models;
using tests.Pages;

namespace tests.Steps;

[Binding]
public sealed class ShoppingStepDefinition
{
    private readonly ScenarioContext _scenarioContext;
    private readonly Actor _actor;

    public ShoppingStepDefinition(ScenarioContext scenarioContext, Actor actor)
    {
        _scenarioContext = scenarioContext;
        _actor = actor;
    }

    [When(@"I enter login credentials with")]
    public void WhenIEnterLoginCredentialsWith(Table table)
    {
        var credentials = table.CreateInstance<LoginCredentials>();
        _actor.AttemptsTo(FillOutLoginForm.With(credentials));
    }

    [Given(@"I am on the Sauce Demo login page")]
    public void GivenIAmOnTheSauceDemoLoginPage()
    {
        _actor.AttemptsTo(Navigate.ToUrl(LoginPage.Url));
    }

    [When(@"I click on the login button")]
    public void WhenIClickOnTheLoginButton()
    {
        _actor.AttemptsTo(Click.On(LoginPage.LoginButton));
    }

    [Then(@"I should be redirected to the inventory page")]
    public void ThenIShouldBeRedirectedToTheInventoryPage()
    {
        _actor.AskingFor(CurrentUrl.FromBrowser()).Should().Match(InventoryPage.Url);
    }
}
