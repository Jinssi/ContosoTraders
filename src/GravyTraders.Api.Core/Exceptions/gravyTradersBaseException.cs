namespace gravyTraders.Api.Core.Exceptions;

public abstract class gravyTradersBaseException : Exception
{
    protected gravyTradersBaseException(string message) : base(message)
    {
    }

    public abstract IActionResult ToActionResult();
}