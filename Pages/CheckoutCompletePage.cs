using Boa.Constrictor.Selenium;
using OpenQA.Selenium;
using static Boa.Constrictor.Selenium.WebLocator;

namespace tests.Pages;

public static class CheckoutCompletePage
{
    public static string Url => "https://www.saucedemo.com/checkout-step-two.html";
    
    public static IWebLocator FinishButton => L(
        "Last name input",
        By.XPath("//button[@data-test=\"finish\"]"));
}