namespace gravyTraders.Api.Core.Requests.Definitions;

public class GetStockRequest : IRequest<IActionResult>
{
    public int ProductId { get; set; }
}