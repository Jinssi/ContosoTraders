﻿namespace GravyTraders.Api.Core.Requests.Definitions;

public class GetCartRequest : IRequest<IActionResult>
{
    public string Email { get; set; }
}