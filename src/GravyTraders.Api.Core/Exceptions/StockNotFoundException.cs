﻿namespace gravyTraders.Api.Core.Exceptions;

public class StockNotFoundException : gravyTradersBaseException
{
    public StockNotFoundException(int productId)
        : base($"Stock not found for product id '{productId}'")
    {
    }

    public override IActionResult ToActionResult()
    {
        return new NotFoundObjectResult(Message);
    }
}