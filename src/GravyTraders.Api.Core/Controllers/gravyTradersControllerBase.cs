namespace gravyTraders.Api.Core.Controllers;

[ApiController]
public class gravyTradersControllerBase : ControllerBase
{
    private readonly IMediator _mediator;

    protected gravyTradersControllerBase(IMediator mediator)
    {
        _mediator = mediator;
    }

    protected async Task<IActionResult> ProcessHttpRequestAsync(IRequest<IActionResult> request)
    {
        try
        {
            return await _mediator.Send(request);
        }
        catch (gravyTradersBaseException gravyTradersBaseException)
        {
            return gravyTradersBaseException.ToActionResult();
        }
        catch (ValidationException validationException)
        {
            return new BadRequestObjectResult(validationException.Message);
        }
    }
}