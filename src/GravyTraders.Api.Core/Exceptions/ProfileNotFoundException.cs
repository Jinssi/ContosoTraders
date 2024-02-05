namespace gravyTraders.Api.Core.Exceptions;

public class ProfileNotFoundException : gravyTradersBaseException
{
    public ProfileNotFoundException(string email)
        : base($"Profile for email '{email}' could not be found.")
    {
    }

    public override IActionResult ToActionResult()
    {
        return new NotFoundObjectResult(Message);
    }
}