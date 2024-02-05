namespace GravyTraders.Api.Core.Exceptions;

public abstract class GravyTradersBaseException : Exception
{
    protected GravyTradersBaseException(string message) : base(message)
    {
    }

    public abstract IActionResult ToActionResult();
}