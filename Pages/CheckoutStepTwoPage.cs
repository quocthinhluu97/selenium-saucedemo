using Boa.Constrictor.Selenium;
using OpenQA.Selenium;
using static Boa.Constrictor.Selenium.WebLocator;

namespace tests.Pages;

public static class CheckoutStepTwoPage
{
    public static string Url => Environment.GetEnvironmentVariable("BASE_URL") + "/checkout-step-two.html";

    public static IWebLocator FinishButton => L(
        "Finish button",
        By.XPath("//button[text()=\"Finish\"]"));

}