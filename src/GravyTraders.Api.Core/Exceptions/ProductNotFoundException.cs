namespace gravyTraders.Api.Core.Exceptions;

public class ProductNotFoundException : gravyTradersBaseException
{
    public ProductNotFoundException(int productId)
        : base($"Product with id '{productId}' could not be found.")
    {
    }

    public override IActionResult ToActionResult()
    {
        return new NotFoundObjectResult(Message);
    }
}