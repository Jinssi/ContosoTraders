﻿namespace gravyTraders.Api.Products.Controllers;

[Route("v1/[controller]")]
[Produces("application/json")]
public class ProfilesController : gravyTradersControllerBase
{
    public ProfilesController(IMediator mediator) : base(mediator)
    {
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IActionResult> GetProfiles()
    {
        var request = new GetProfilesRequest();

        return await ProcessHttpRequestAsync(request);
    }

    [HttpGet("me")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IActionResult> GetProfile()
    {
        var email = "admin@gravytraders.com";
        var request = new GetProfileRequest
        {
            Email = email
        };
        return await ProcessHttpRequestAsync(request);
    }
}