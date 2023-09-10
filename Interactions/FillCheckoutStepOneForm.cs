using Boa.Constrictor.Screenplay;
using Boa.Constrictor.Selenium;
using tests.Models;
using tests.Pages;

namespace tests.Interactions;

public class FillCheckoutStepOneForm : ITask
{
    private readonly CheckoutInformation _checkoutInformation;

    private FillCheckoutStepOneForm(CheckoutInformation checkoutInformation)
    {
        _checkoutInformation = checkoutInformation;
    }

    public static ITask With(CheckoutInformation checkoutInformation)
    {
        return new FillCheckoutStepOneForm(checkoutInformation);
    }

    public void PerformAs(IActor actor)
    {
        actor.AttemptsTo(
            SendKeys.To(CheckoutStepOnePage.FirstNameInput, _checkoutInformation.FirstName),
            SendKeys.To(CheckoutStepOnePage.LastNameInput, _checkoutInformation.LastName),
            SendKeys.To(CheckoutStepOnePage.ZipCodeInput, _checkoutInformation.ZipCode)
        );
    }
}