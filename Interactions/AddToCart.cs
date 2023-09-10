using Boa.Constrictor.Screenplay;
using Boa.Constrictor.Selenium;
using tests.Models;
using tests.Pages;

namespace tests.Interactions;

public class AddToCart : ITask
{
    private readonly string _item;

    private AddToCart(string item)
    {
        _item = item;
    }

    public static ITask With(string item)
    {
        return new AddToCart(item);
    }

    public void PerformAs(IActor actor)
    {
        actor.AttemptsTo(Click.On(InventoryPage.AddToCartButton(_item)));
    }
}