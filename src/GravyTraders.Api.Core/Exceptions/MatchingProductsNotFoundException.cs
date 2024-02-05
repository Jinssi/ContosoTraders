namespace gravyTraders.Api.Core.Exceptions;

public class MatchingProductsNotFoundException : gravyTradersBaseException
{
    public MatchingProductsNotFoundException(string tags)
        : base($"No matching products found for tags :  {tags}")
    {
    }

    public override IActionResult ToActionResult()
    {
        return new NotFoundObjectResult(Message);
    }
}