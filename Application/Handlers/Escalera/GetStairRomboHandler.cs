using Application.Queries;
using Domain.Services;
using Domain.Shared;
using MediatR;

namespace Application.Handlers;

public class GetStairRomboHandler(IEscaleraService service, IClassResponse<string> classResponse) : IRequestHandler<GetStairRomboQuery, IClassResponse<string>>
{
    public async Task<IClassResponse<string>> Handle(GetStairRomboQuery request, CancellationToken cancellationToken)
    {
        var response = await service.GetStairRomboCase(request.Number);
        return response.IsSuccess ? classResponse.SetSuccess(response.Data!, response.StatusCode) : classResponse.SetError(response.ErrorMessage!, response.StatusCode);
    }
}