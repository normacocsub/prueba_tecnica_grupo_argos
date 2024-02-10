using Application.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MediaController(ISender mediator) : ControllerBase
{
    [HttpGet("GetMedia")]
    public async Task<IActionResult> GetMedia([FromQuery] GetMediaQuery query)
    {
        var response = await mediator.Send(query);
        return response.IsSuccess ? Ok(response.Data) : StatusCode(response.StatusCode, new { response.ErrorMessage});
    }

    [HttpGet("GetMediaArmonica")]
    public async Task<IActionResult> GetMediaArmonica([FromQuery] GetMediaArmonicaQuery query)
    {
        var response = await mediator.Send(query);
        return response.IsSuccess ? Ok(response.Data) : StatusCode(response.StatusCode, new { response.ErrorMessage});
    }

    [HttpGet("GetMediana")]
    public async Task<IActionResult> GetMediana([FromQuery] GetMedianaQuery query)
    {
        var response = await mediator.Send(query);
        return response.IsSuccess ? Ok(response.Data) : StatusCode(response.StatusCode, new { response.ErrorMessage});
    }
}