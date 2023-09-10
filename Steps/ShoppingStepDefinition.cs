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

    [Given(@"I am on the inventory page")]
    [Then(@"I should be redirected to the inventory page")]
    public void ThenIShouldBeRedirectedToTheInventoryPage()
    {
        _actor.AskingFor(CurrentUrl.FromBrowser()).Should().Match(InventoryPage.Url);
    }

    [When(@"I add '(.*)' to cart")]
    public void WhenIAddToCart(string item)
    {
        _actor.AttemptsTo(AddToCart.With(item));
    }

    [When(@"I go to the cart page")]
    public void WhenIGoToTheCartPage()
    {
        _actor.AttemptsTo(Click.On(InventoryPage.ShoppingCartLink));
    }

    [Then(@"I can see '(.*)' item")]
    public void ThenICanSeeItem(string item)
    {
        _actor.AskingFor(Appearance.Of(CartPage.Item(item))).Should().BeTrue();
    }

    [Given(@"I am on the cart page")]
    public void GivenIAmOnTheCartPage()
    {
        _actor.AskingFor(CurrentUrl.FromBrowser()).Should().Match(CartPage.Url);
    }

    [When(@"I click on the checkout button")]
    public void WhenIClickOnTheCheckoutButton()
    {
        _actor.AttemptsTo(Click.On(CartPage.CheckoutButton));
    }

    [Given(@"I am on the checkout step one page")]
    [Then(@"I got navigated to the checkout step one page")]
    public void ThenIGotNavigatedToTheCheckoutStepOnePage()
    {
        _actor.AskingFor(CurrentUrl.FromBrowser()).Should().Match(CheckoutStepOnePage.Url);
    }

    [When(@"I fill the checkout information form with")]
    public void WhenIFillTheCheckoutInformationFormWith(Table table)
    {
        var checkoutInformation = table.CreateInstance<CheckoutInformation>();
        _actor.AttemptsTo(FillCheckoutStepOneForm.With(checkoutInformation));
    }

    [When(@"I click on the continue button")]
    public void WhenIClickOnTheContinueButton()
    {
        _actor.AttemptsTo(Click.On(CheckoutStepOnePage.ContinueButton));
    }

    [Given(@"I am on the checkout step two page")]
    [Then(@"I got navigated to the checkout step two page")]
    public void ThenIGotNavigatedToTheCheckoutStepTwoPage()
    {
        _actor.AskingFor(CurrentUrl.FromBrowser()).Should().Match(CheckoutStepTwoPage.Url);
    }

    [When(@"I click on the finish button")]
    public void WhenIClickOnTheFinishButton()
    {
        _actor.AttemptsTo(Click.On(CheckoutStepTwoPage.FinishButton));
    }

    [Then(@"I got navigated to the checkout complete page")]
    public void ThenIGotNavigatedToTheCheckoutCompletePage()
    {
        _actor.AskingFor(CurrentUrl.FromBrowser()).Should().Match(CheckoutCompletePage.Url);
    }

    [Then(@"I can see the '(.*)' text")]
    public void ThenICanSeeTheText(string text)
    {
        _actor.AskingFor(Appearance.Of(CheckoutCompletePage.Text(text))).Should().BeTrue();
    }
}
