using Boa.Constrictor.Screenplay;
using Boa.Constrictor.Selenium;
using tests.Models;
using tests.Pages;

namespace tests.Interactions;

public class FillOutLoginForm : ITask
{
    private readonly LoginCredentials _credentials;

    private FillOutLoginForm(LoginCredentials credentials)
    {
        _credentials = credentials;
    }

    public static ITask With(LoginCredentials credentials)
    {
        return new FillOutLoginForm(credentials);
    }

    public void PerformAs(IActor actor)
    {
        actor.AttemptsTo(
            SendKeys.To(LoginPage.UsernameInput, _credentials.Username), 
            SendKeys.To(LoginPage.PasswordInput, _credentials.Password)
        );
    }
}