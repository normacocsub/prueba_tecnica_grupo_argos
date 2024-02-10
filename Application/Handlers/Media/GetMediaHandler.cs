using Application.Queries;
using Domain.Services;
using Domain.Shared;
using MediatR;

namespace Application.Handlers;

public class GetMediaHandler(IMediaService service, IClassResponse<float> classResponse) : IRequestHandler<GetMediaQuery, IClassResponse<float>>
{
    public async Task<IClassResponse<float>> Handle(GetMediaQuery request, CancellationToken cancellationToken)
    {
        var response = await service.GetMedia(request.Numbers);
        return response.IsSuccess ? classResponse.SetSuccess(response.Data, response.StatusCode) : classResponse.SetError(response.ErrorMessage!, response.StatusCode);
    }
}