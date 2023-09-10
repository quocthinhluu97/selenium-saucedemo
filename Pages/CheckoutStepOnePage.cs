using Boa.Constrictor.Selenium;
using OpenQA.Selenium;
using static Boa.Constrictor.Selenium.WebLocator;

namespace tests.Pages;

public static class CheckoutStepOnePage
{
    public static string Url => "https://www.saucedemo.com/checkout-step-one.html";
    public static IWebLocator FirstNameInput => L(
        "First name input",
        By.CssSelector("[placeholder=\"First Name\"]"));
    
    public static IWebLocator LastNameInput => L(
        "Last name input",
        By.CssSelector("[placeholder=\"Last Name\"]"));
    
    public static IWebLocator ZipCodeInput => L(
        "Zip code input",
        By.CssSelector("[placeholder=\"Zip/Postal Code\"]"));

    public static IWebLocator ContinueButton => L(
        "Continue button",
        By.Name("continue"));
}