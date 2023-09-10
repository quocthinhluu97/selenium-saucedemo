using Boa.Constrictor.Selenium;
using OpenQA.Selenium;
using static Boa.Constrictor.Selenium.WebLocator;

namespace tests.Pages;

public static class CheckoutStepTwoPage
{
    public static string Url => "https://www.saucedemo.com/checkout-step-one.html";

    public static IWebLocator ContinueButton => L(
        "Continue button",
        By.XPath("//input[@data-test=\"continue\"]"));
    
    public static IWebLocator FirstNameInput => L(
        "First name input",
        By.XPath("//input[@data-test=\"firstName\"]"));
    
    public static IWebLocator LastNameInput => L(
        "Last name input",
        By.XPath("//input[@data-test=\"lastName\"]"));
    
    public static IWebLocator ZipCodeInput => L(
        "Postal code input",
        By.XPath("//input[@data-test=\"postalCode\"]"));
}