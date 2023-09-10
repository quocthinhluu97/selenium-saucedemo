using Boa.Constrictor.Selenium;
using OpenQA.Selenium;
using static Boa.Constrictor.Selenium.WebLocator;

namespace tests.Pages;

public static class CartPage
{
    public static string Url => "https://www.saucedemo.com/cart.html";

    public static IWebLocator Item(string item) => L(
        "Inventory item",
        By.LinkText(item));
    
    public static IWebLocator CheckoutButton => L(
        "Checkout button",
        By.XPath("//button[@id=\"checkout\"]"));
}