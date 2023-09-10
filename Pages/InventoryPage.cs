using Boa.Constrictor.Selenium;
using OpenQA.Selenium;
using static Boa.Constrictor.Selenium.WebLocator;

namespace tests.Pages;

public class InventoryPage
{
    public static string Url => "https://www.saucedemo.com/inventory.html";
    
    public static IWebLocator ShoppingCartLink => L(
        "Go to shopping cart link",
        By.XPath("//div[@id=\"shopping_cart_container\"]"));

    public static IWebLocator AddToCartButton(string item) => L(
        "Add to cart button by name of item",
        By.XPath($"//div[text()='{item}']/ancestor::div[@class=\"inventory_item\"]//button[@data-test=\"add-to-cart-sauce-labs-backpack\"]"));
}