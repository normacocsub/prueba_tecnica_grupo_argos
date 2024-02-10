using Application.Queries;
using Domain.Services;
using Domain.Shared;
using MediatR;

namespace Application.Handlers;

public class GetMediaArmonicaHandler(IMediaService service, IClassResponse<float> classResponse) : IRequestHandler<GetMediaArmonicaQuery, IClassResponse<float>>
{
    public async Task<IClassResponse<float>> Handle(GetMediaArmonicaQuery request, CancellationToken cancellationToken)
    {
        var response = await service.GetMediaArmonica(request.Numbers);
        return response.IsSuccess ? classResponse.SetSuccess(response.Data, response.StatusCode) : classResponse.SetError(response.ErrorMessage!, response.StatusCode);
    }
}