using Application.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EscaleraController(ISender mediator) : ControllerBase
{
    [HttpGet("GetStairAgentA")]
    public async Task<IActionResult> GetStairRigth([FromQuery] GetStairRigthQuery query)
    {
        var response = await mediator.Send(query);
        return response.IsSuccess ? Ok(response.Data) : StatusCode(response.StatusCode, new { response.ErrorMessage});
    }
    
    [HttpGet("GetStairAgentB")]
    public async Task<IActionResult> GetStairInvertRigth([FromQuery] GetStairInvertRigthQuery query)
    {
        var response = await mediator.Send(query);
        return response.IsSuccess ? Ok(response.Data) : StatusCode(response.StatusCode, new { response.ErrorMessage});
    }
    
    [HttpGet("GetStairAgentC")]
    public async Task<IActionResult> GetStairRombo([FromQuery] GetStairRomboQuery query)
    {
        var response = await mediator.Send(query);
        return response.IsSuccess ? Ok(response.Data) : StatusCode(response.StatusCode, new { response.ErrorMessage});
    }
}