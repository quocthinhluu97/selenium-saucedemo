using Boa.Constrictor.Selenium;
using OpenQA.Selenium;
using static Boa.Constrictor.Selenium.WebLocator;

namespace tests.Pages;

public static class LoginPage
{
    public static string Url => "https://www.saucedemo.com/";

    public static IWebLocator UsernameInput => L(
        "Username input",
        By.Name("user-name"));
    
    public static IWebLocator PasswordInput => L(
        "Password input",
        By.Name("password"));

    public static IWebLocator LoginButton => L(
"Login button",
        By. Name("login-button")
    );
}