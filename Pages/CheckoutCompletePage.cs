﻿using Boa.Constrictor.Selenium;
using OpenQA.Selenium;
using static Boa.Constrictor.Selenium.WebLocator;

namespace tests.Pages;

public static class CheckoutCompletePage
{
    public static string Url => Environment.GetEnvironmentVariable("BASE_URL") + "/checkout-complete.html";
    
    public static IWebLocator Text (string text) => L(
        "Text that can be found on this page",
        By.XPath($"//*[text()=\"{text}\"]"));
}