using Boa.Constrictor.Screenplay;
using Boa.Constrictor.Selenium;
using tests.Models;
using tests.Pages;

namespace tests.Interactions;

public class FillCheckoutStepOneForm : ITask
{
    private readonly LoginCredentials _credentials;

    private FillCheckoutStepOneForm(LoginCredentials credentials)
    {
        _credentials = credentials;
    }

    public static ITask With(LoginCredentials credentials)
    {
        return new FillCheckoutStepOneForm(credentials);
    }

    public void PerformAs(IActor actor)
    {
        actor.AttemptsTo(
            SendKeys.To(LoginPage.UsernameInput, _credentials.Username), 
            SendKeys.To(LoginPage.PasswordInput, _credentials.Password)
        );
    }
}