using Microsoft.AspNetCore.Mvc;
using MediatR;

[Route("api/[controller]")]
[ApiController]
public class PurchaseNotificationController : ControllerBase
{
    IMediator _mediator;

    public PurchaseNotificationController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreatePurchaseNotificationRequest request)
    {
        try
        {
            var notification = await _mediator.Send(request);
            return Ok(notification);
        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.Message);
        }
    }
}