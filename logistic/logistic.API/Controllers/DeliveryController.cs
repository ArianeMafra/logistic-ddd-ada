using Microsoft.AspNetCore.Mvc;
using MediatR;

[Route("api/[controller]")]
[ApiController]
public class DeliveryController : ControllerBase
{
    IMediator _mediator;

    public DeliveryController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateDeliveryRequest request)
    {
        try
        {
            var delivery = await _mediator.Send(request);
            return Ok(delivery);
        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.Message);
        }
    }
}