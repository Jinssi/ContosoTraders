namespace GravyTraders.Api.Core.Controllers;

[ApiController]
public class GravyTradersControllerBase : ControllerBase
{
    private readonly IMediator _mediator;

    protected GravyTradersControllerBase(IMediator mediator)
    {
        _mediator = mediator;
    }

    protected async Task<IActionResult> ProcessHttpRequestAsync(IRequest<IActionResult> request)
    {
        try
        {
            return await _mediator.Send(request);
        }
        catch (GravyTradersBaseException GravyTradersBaseException)
        {
            return GravyTradersBaseException.ToActionResult();
        }
        catch (ValidationException validationException)
        {
            return new BadRequestObjectResult(validationException.Message);
        }
    }
}