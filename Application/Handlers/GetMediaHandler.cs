using Application.Queries;
using Domain.Services;
using Domain.Shared;
using MediatR;

namespace Application.Handlers;

public class GetMediaHandler(IMediaService service, IClassResponse<int> classResponse) : IRequestHandler<GetMediaQuery, IClassResponse<int>>
{
    public async Task<IClassResponse<int>> Handle(GetMediaQuery request, CancellationToken cancellationToken)
    {
        var response = await service.GetMedia();
        return response.IsSuccess ? classResponse.SetSuccess(response.Data!, response.StatusCode) : classResponse.SetError(response.ErrorMessage!, response.StatusCode);
    }
}