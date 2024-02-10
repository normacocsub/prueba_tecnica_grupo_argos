using Application.Queries;
using Domain.Services;
using Domain.Shared;
using MediatR;

namespace Application.Handlers;

public class GetMedianaHandler(IMediaService service, IClassResponse<float> classResponse) : IRequestHandler<GetMedianaQuery, IClassResponse<float>>
{
    public async Task<IClassResponse<float>> Handle(GetMedianaQuery request, CancellationToken cancellationToken)
    {
        var response = await service.GetMediana(request.Numbers);
        return response.IsSuccess ? classResponse.SetSuccess(response.Data, response.StatusCode) : classResponse.SetError(response.ErrorMessage!, response.StatusCode);
    }
}